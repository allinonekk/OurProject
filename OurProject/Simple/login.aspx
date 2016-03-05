<%@ Page Language="C#" MasterPageFile="~/4guys.master" %>
<script runat="server">
	private void Page_Load()
	{
		Login1.Focus();
	}
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="c" Runat="Server">
	<asp:Login ID="Login1" runat="server" BackColor="#FFFFCC" BorderColor="#666666" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" >
		<TitleTextStyle BackColor="#4444AA" Font-Bold="True" ForeColor="#FFFFFF" />
	</asp:Login>
	
	<h2>
	    You can log into the system as an Administrator using the username and password "Dan Clem" and "dan" (omitting
	    the quotation marks).	    
	</h2>
	<h2>
	    You can log into the system as a non-Administrator using any of the following user names:
	    "Edward Eel", "Franklin Forester", "Gordy Gordon", "Harold Houdini", or "Ike Iverson". The
	    password for each of these users is their first name, all lower case.
	</h2>
</asp:Content>

