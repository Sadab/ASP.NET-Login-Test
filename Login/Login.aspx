<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Login" runat="server">
        <div>
            <div>
                <asp:Label ID="label1" runat="server" Text="UserName"></asp:Label><br />
                <asp:TextBox ID="user" runat="server" style="margin-right: 0px" Width="118px" ></asp:TextBox>
                <br />
                <asp:Label ID="label2" runat="server" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="pass" runat="server" TextMode="Password" OnTextChanged="pass_TextChanged" ></asp:TextBox>
                <br />
                    <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
                    <asp:CheckBox ID="checkBox" runat="server" />
                <br />
                <asp:Button ID="LoginBtn" runat="server" OnClick="LoginBtn_Click" Text="Login" />
                <asp:Button ID="RegisterBtn" runat="server" Text="Register Now!" OnClick="RegisterBtn_Click" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
