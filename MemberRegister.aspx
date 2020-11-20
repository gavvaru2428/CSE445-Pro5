<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegister.aspx.cs" Inherits="project5.MemberRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Register Here<br />
            <br />
            Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNameReg" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPassReg" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            Retype Password:&nbsp;
            <asp:TextBox ID="txtRetypePass" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <br />
            Image Verification Code<br />
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Captcha.aspx" />
            <br />
            <br />
            Please Enter the Verification Code<br />
            <asp:TextBox ID="imgVerBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
            &nbsp;&nbsp;
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="HOME" />
            <br />
            <br />
            <asp:Label ID="lblRegister" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
