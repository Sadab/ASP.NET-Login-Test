<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Login.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Input Username:"></asp:Label>
        <asp:TextBox ID="inputUser" runat="server" required></asp:TextBox>
        <br />
        <asp:Button ID="next" runat="server" Text="Next" OnClick="next_Click" />
    
    </div>
    </form>
</body>
</html>
