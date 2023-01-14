<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please sign in<br />
        </div>
        Username<p>
            <asp:TextBox ID="username" runat="server" ></asp:TextBox>
        </p>
        Password<p>
            <asp:TextBox ID="password" runat="server" ></asp:TextBox>
        </p>
        <asp:Button ID="signin" runat="server" OnClick="SignIn_Click" Text="Sign in" />
        <p>
            <asp:Button ID="StudentReg" runat="server" OnClick="StudentReg_Click" Text="Register as Student" />
        </p>
        <asp:Button ID="InstReg" runat="server" Text="Register as Instructor" OnClick="InstReg_Click" />
    </form>
</body>
</html>
