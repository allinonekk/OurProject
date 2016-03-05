<%@ Page Language="C#" MasterPageFile="~/4guys.master" %>
<%@ Import Namespace="System.Web.Configuration" %>

<script runat="server">
	private const string VirtualImageRoot = "~/";
	private string selectedRole, selectedUser;
	
	private void Page_Init()
	{
		UserRoles.DataSource = Roles.GetAllRoles();
		UserRoles.DataBind();

		UserList.DataSource = Membership.GetAllUsers();
		UserList.DataBind();

		FolderTree.Nodes.Clear();
	}
	
	private void Page_Load()
	{
		selectedRole = UserRoles.SelectedValue;
		selectedUser = UserList.SelectedValue;
	}
	
	private void Page_PreRender()
	{
	}
	
	private void PopulateTree(string byUserOrRole)
	{
		// Populate the tree based on the subfolders of the specified VirtualImageRoot
		DirectoryInfo rootFolder = new DirectoryInfo(Server.MapPath(VirtualImageRoot));
		TreeNode root = AddNodeAndDescendents(byUserOrRole, rootFolder, null);
		FolderTree.Nodes.Add(root);
	}
	
	private TreeNode AddNodeAndDescendents(string byUserOrRole, DirectoryInfo folder, TreeNode parentNode)
	{
		// Add the TreeNode, displaying the folder's name and storing the full path to the folder as the value...
		string virtualFolderPath;
		if (parentNode == null)
		{
			virtualFolderPath = VirtualImageRoot;
		}
		else
		{
			virtualFolderPath = parentNode.Value + folder.Name + "/";
		}
		
		// Instantiate the objects that we'll use to check folder security on each tree node.
		Configuration config = WebConfigurationManager.OpenWebConfiguration(virtualFolderPath);
		SystemWebSectionGroup systemWeb = (SystemWebSectionGroup)config.GetSectionGroup("system.web");
		AuthorizationSection section = (AuthorizationSection)systemWeb.Sections["authorization"];

		string action;
		if (byUserOrRole == "ByRole")
		{
			action = GetTheRuleForThisRole(section, virtualFolderPath);
		}
		else if (byUserOrRole == "ByUser")
		{
			action = GetTheRuleForThisUser(section, virtualFolderPath);
		}
		else
		{
			action = "";
		}
		
		//  This is where I wanna adjust the folder name.
		TreeNode node = new TreeNode(folder.Name + " (" + action + ")", virtualFolderPath);
		node.ImageUrl = (action.Substring(0, 5) == "ALLOW") ? "/Simple/i/greenlight.gif" : "/Simple/i/redlight.gif";
		
		// Managers should have the right to VIEW site security settings, but not change them.
		// node.NavigateUrl = "access_rules.aspx?selectedFolderName=" + folder.Name;
		
		// Recurse through this folder's subfolders
		DirectoryInfo[] subFolders = folder.GetDirectories();
		foreach(DirectoryInfo subFolder in subFolders)
		{
			if (subFolder.Name != "_controls" && subFolder.Name != "App_Data")
			{
				TreeNode child = AddNodeAndDescendents(byUserOrRole, subFolder, node);
				node.ChildNodes.Add(child);
			}
		}
		return node; // Return the new TreeNode
	}

	private string GetTheRuleForThisRole(AuthorizationSection section, string folder)
	{
		/*
		 * Dan Clem, 3/19/2007.
		 * We know that rules are returned in order, so we can return upon first match.
		 * Even if there were conflicting entries for the requested Role in the config file,
		 * we know that the first rule for the given role will supersede the later entry.
		 * 
		 * I didn't readily find a method called "GetPermissionForThisRoleInThisFolder",
		 * so I'm building the logic myself based on my understanding of things:
		 * The first matching rule is applied, so the way I figure it, no matter whether we are 
		 * testing for 1) an anonymous user, or 2) an authenticated user not belonging to a role, 
		 * or 3) an actual role, the logic will be the same: take the first match on either the 
		 * actual role OR the all users (*) symbol.
		 * 
		 * Note that I'm not checking for ALL ROLES (*), even though I believe that's technically
		 * an option with ASP.NET. At first I thought ALL ROLES is equivalent to AUTHENTICATED, but I
		 * do realize a subtle distinction: ALL ROLES would read "Let the user see this resource if
		 * he belongs to ANY role." If you were to combine this with a lower rule that DENIED ALL USERS
		 * (DENY USERS="*"), then this would have the intended effect of blocking authenticated users
		 * that don't belong to any role. On reflection, I should check to see how this works, because
		 * this is a potentially useful way to deploy security. I'm new at this. This is fun.
		 * Note that if I do this, I'll need to add an asterik to my ADD ROLE dropdownlist, which is
		 * interesting, considering that the WSAT does NOT provide the feature.
		 * 
		 * Well, I tried this by manually adding "<allow roles="*" />" to the config file.
		 * This resulted in a page error as follows:
		 * Parser Error Message: Authorization rule names cannot contain the '*' character.
		 * So it appears that this is NOT an option, even though I can see how it would be desirable.
		 * At any rate, it's one less thing to worry about right now.
		 * 
		 * Long story short, I've developed a best practice for providing role-based security on a folder:
		 * ALLOW SPECIFIC ROLE, then DENY ALL USERS (*).
		 */

		foreach (AuthorizationRule rule in section.Rules)
		{
			/*
			 * Both Users and Roles are collections of strings, not a single string, 
			 * so even though my tool (as well as the WSAT
			 * that is accessed from Visual Studio 2005) provides a single-selection dropdownlist
			 * for specifying a single ROLE for a RULE, I'll treat it as the collection that it is,
			 * since it's possible that someone could modify the Web.config file manually.
			 * 
			 * Note to self: remember that it does not matter whether we first check the users 
			 * or first check the roles. Remember that we're dealing with a single rule inside
			 * this foreach block, and a rule can have only a single action. A match in either 
			 * users or roles is completely equivalent.
			 */
			foreach (string user in rule.Users)
			{
				if (user == "*")
				{
					return rule.Action.ToString().ToUpper() + ": All Users";
				}
			}
			foreach (string role in rule.Roles)
			{
				if (role == selectedRole)
				{
					return rule.Action.ToString().ToUpper() + ": Role=" + role;
				}
			}
		}
		/*
		 * Dan Clem, 3/19/2007.
		 * I think we'll always have a match, because the Machine.config or master Web.config
		 * appears to have a default entry for ALLOW *.
		 * Nevertheless, I'll return "Allow" because I haven't researched what happens if said 
		 * default entry is manually deleted. Better to report a false ALLOW than a false DENY.
		 */
		return "Allow";
	}

	private string GetTheRuleForThisUser(AuthorizationSection section, string folder)
	{
		foreach (AuthorizationRule rule in section.Rules)
		{
			foreach (string user in rule.Users)
			{
				if (user == "*")
				{
					return rule.Action.ToString().ToUpper() + ": All Users";
				}
				else if (user == selectedUser)
				{
					return rule.Action.ToString().ToUpper() + ": User=" + user;
				}
			}

			// Don't forget that users might belong to some roles!
			foreach (string role in rule.Roles)
			{
				if (Roles.IsUserInRole(selectedUser, role))
				{
					return rule.Action.ToString().ToUpper() + ": Role=" + role;
				}
			}
		}
		return "ALLOW";
	}

	private void DisplayRoleSummary(object sender, EventArgs e)
	{
		FolderTree.Nodes.Clear();
		UserList.SelectedIndex = 0;
		if (UserRoles.SelectedIndex > 0)
		{
			PopulateTree("ByRole");
			FolderTree.ExpandAll();
		}
	}

	private void DisplayUserSummary(object sender, EventArgs e)
	{
		FolderTree.Nodes.Clear();
		UserRoles.SelectedIndex = 0;
		if (UserList.SelectedIndex > 0)
		{
			PopulateTree("ByUser");
			FolderTree.ExpandAll();
		}
	}

	private void DisplaySecuritySummary(object sender, TreeNodeEventArgs e)
	{
		e.Node.ShowCheckBox = true;
	}
	
	protected void FolderTree_SelectedNodeChanged(object sender, EventArgs e)
	{
	}
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="c" Runat="Server">

<table class="webparts">
<tr>
	<th>Website Access Security Summary</th>
</tr>
<tr>
	<td class="details" valign="top">
		<table>
		<tr>
			<td valign="top" style="padding-right: 30px;">
		
		<asp:DropDownList ID="UserRoles" runat="server" AppendDataBoundItems="true"
			AutoPostBack="true" OnSelectedIndexChanged="DisplayRoleSummary">
		<asp:ListItem>Select Role</asp:ListItem>
		</asp:DropDownList>
		
		&nbsp;&nbsp;&nbsp;&nbsp;<b>&mdash;&nbsp;&nbsp;OR&nbsp;&nbsp;&mdash;</b>
		&nbsp;&nbsp;&nbsp;				
		
		<asp:DropDownList ID="UserList" runat="server" AppendDataBoundItems="true"
			AutoPostBack="true" OnSelectedIndexChanged="DisplayUserSummary">
		<asp:ListItem>Select User</asp:ListItem>
		<asp:ListItem Text="Anonymous users (?)" Value="?"></asp:ListItem>
		<asp:ListItem Text="Authenticated users not in a role (*)" Value="*"></asp:ListItem>
		</asp:DropDownList>	
		
		<br />
		
		<div class="treeview">
		<asp:TreeView runat="server" ID="FolderTree"
			OnSelectedNodeChanged="FolderTree_SelectedNodeChanged"
			>
			<RootNodeStyle ImageUrl="/Simple/i/folder.gif" />
			<ParentNodeStyle ImageUrl="/Simple/i/folder.gif" />
			<LeafNodeStyle ImageUrl="/Simple/i/folder.gif" />
			<SelectedNodeStyle Font-Underline="true" ForeColor="#A21818" />
		</asp:TreeView>
				</div>
			</td>
		</tr>
		</table>
	</td>
</tr>
</table>


</asp:Content>

