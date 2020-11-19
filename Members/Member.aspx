<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="project5.Members.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% Response.Write("Hello " + Context.User.Identity.Name + ", "); %>Welcome to Member Page<br />
            <br />
            As a member you are entitled to use the below services.<br />
            <br />
            <asp:Button ID="btnProducts" runat="server" OnClick="btnProducts_Click" Text="Find Products by Keyword Service" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnWeather" runat="server" OnClick="btnWeather_Click" Text="Weather5Day Service" />
            <br />
            <br />
            <asp:Button ID="btnDll" runat="server" OnClick="btnDll_Click" Text="DLL Encryption/Decryption" />
            <br />
            <br />
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="HOME" />
        </div>

    </form>
</body>
</html>
