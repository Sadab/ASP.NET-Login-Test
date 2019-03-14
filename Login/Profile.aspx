<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Login.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="label" runat="server" Text="Welcome"></asp:Label>
        <asp:Label ID="userNameDisp" runat="server" Text=""></asp:Label>
    
        <br />
        <asp:Button ID="LogoutBtn" runat="server" Text="Logout" OnClick="LogoutBtn_Click" />
    
    </div>
    </form>
</body>
</html>
