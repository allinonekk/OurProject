<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AllInOneConfigFile.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <script runat="server">
	private void Page_Load()
	{
		Login1.Focus();
	}
</script>
    <div>

    <asp:Login ID="Login1" runat="server" BackColor="#FFFFCC" BorderColor="#666666" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" >
		<TitleTextStyle BackColor="#4444AA" Font-Bold="True" ForeColor="#FFFFFF" />
	</asp:Login>
    
    </div>
    </form>
</body>
</html>
