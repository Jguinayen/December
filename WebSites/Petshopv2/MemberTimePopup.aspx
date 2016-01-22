<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberTimePopup.aspx.cs" Inherits="MemberTimePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul>
<li><asp:Button Text="Sign In" runat="server" ID="submit" CssClass="smallButton"></asp:Button></li>
    </ul>
        <asp:Button class="minimal" ID="btnAdminTimePopup09am" runat="server" Text="09:00 AM" OnClick="btnAdminTimePopup09am_Click" /><br />
        <asp:Button ID="btnAdminTimePopup10am" runat="server" Text="10:00 AM" OnClick="btnAdminTimePopup10am_Click" /><br />
        <asp:Button ID="btnAdminTimePopup11am" runat="server" Text="11:00 AM" OnClick="btnAdminTimePopup11am_Click" /><br />
        <asp:Button ID="btnAdminTimePopup12pm" runat="server" Text="12:00 PM" OnClick="btnAdminTimePopup12pm_Click" /><br />
        <asp:Button ID="btnAdminTimePopup01pm" runat="server" Text="01:00 PM" OnClick="btnAdminTimePopup01pm_Click" /><br />
        <asp:Button ID="btnAdminTimePopup02pm" runat="server" Text="02:00 PM" OnClick="btnAdminTimePopup02pm_Click" /><br />
        <asp:Button ID="btnAdminTimePopup03pm" runat="server" Text="03:00 PM" OnClick="btnAdminTimePopup03pm_Click" /><br />
        <asp:Button ID="btnAdminTimePopup04pm" runat="server" Text="04:00 PM" OnClick="btnAdminTimePopup04pm_Click" />
        <br />
        <asp:TextBox ID="txtAdminTimePopupTimePick" runat="server"></asp:TextBox>
        <br />

    </div>
    </form>
</body>
</html>
