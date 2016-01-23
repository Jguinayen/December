<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminTimePopup.aspx.cs" Inherits="AdminTimePopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="components/bootstrap2/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnAdminTimePopup09am" runat="server" Text="09:00 AM" OnClick="btnAdminTimePopup09am_Click" Width="100%" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;" /><br />
        <asp:Button ID="btnAdminTimePopup10am" runat="server" Text="10:00 AM" OnClick="btnAdminTimePopup10am_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;"/><br />
        <asp:Button ID="btnAdminTimePopup11am" runat="server" Text="11:00 AM" OnClick="btnAdminTimePopup11am_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;"/><br />
        <asp:Button ID="btnAdminTimePopup12pm" runat="server" Text="12:00 PM" OnClick="btnAdminTimePopup12pm_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;"/><br />
        <asp:Button ID="btnAdminTimePopup01pm" runat="server" Text="01:00 PM" OnClick="btnAdminTimePopup01pm_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;"/><br />
        <asp:Button ID="btnAdminTimePopup02pm" runat="server" Text="02:00 PM" OnClick="btnAdminTimePopup02pm_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;"/><br />
        <asp:Button ID="btnAdminTimePopup03pm" runat="server" Text="03:00 PM" OnClick="btnAdminTimePopup03pm_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;" /><br />
        <asp:Button ID="btnAdminTimePopup04pm" runat="server" Text="04:00 PM" OnClick="btnAdminTimePopup04pm_Click" CssClass="btn btn-success" style="width:100%; margin: 2px 0px 2px 0px;"/>
        <br />
        <asp:TextBox ID="txtAdminTimePopupTimePick" runat="server"></asp:TextBox>
        <br />

    </div>
    </form>
</body>
</html>
