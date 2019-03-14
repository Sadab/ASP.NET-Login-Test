<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register2.aspx.cs" Inherits="Login.Register2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="inputPass" runat="server" TextMode="Password" required OnTextChanged="inputPass_TextChanged"></asp:TextBox>
    
        <br />
        <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" />
    
    </div>
    </form>
</body>
</html>
