<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentRegister.aspx.cs" Inherits="GUCera.studentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        First Name<p>
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
        </p>
        Last Name<p>
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
        </p>
        <p>
            Password</p>
        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
        <p>
            e-mail</p>
        <asp:TextBox ID="mail" runat="server"></asp:TextBox>
        <br />
        gender<br />
        <asp:DropDownList ID="gender" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="1">female</asp:ListItem>
            <asp:ListItem Value="0">male</asp:ListItem>
        </asp:DropDownList>
        <br />
        Address<p>
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="reg" runat="server" Text="Register" OnClick="reg_Click" />
    </form>
</body>
</html>
