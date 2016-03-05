<%@ Page Language="C#" %>
<script runat="server">
	/*
	 * Dan Clem, 2/12/2007.
	 * This might not be the most graceful way to do this, but it's not too bad.
	 * I didn't like the idea of having the logout code in the master file.
	 * So I put it here.
	 */
	 
	private void Page_Load(object sender, EventArgs e)
	{
		FormsAuthentication.SignOut();
		Response.Redirect("/Simple/default.aspx?task=logout");
	}
</script>
