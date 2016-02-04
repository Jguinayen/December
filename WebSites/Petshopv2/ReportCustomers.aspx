<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="ReportCustomers.aspx.cs" Inherits="ReportCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">
    <p id="pagetitle">Reports - Customers</p>

 <%-- REPORTS MENU --%>

        <div style="font: normal 12px arial;">

        <asp:Button ID="Button1" runat="server" Text="Export to Excel" OnClick="Button1_Click" />
        <br /><br />
    
<<<<<<< HEAD
        <asp:GridView ID="GridViewCustomer" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Both" Width="100%" BorderWidth="2" CellSpacing="2" BorderColor="#ffffff">
=======
        <asp:GridView ID="GridViewCustomer" runat="server" CellPadding="4" ForeColor="#333333" GridLines="BOTH" Width="90%" BorderWidth="2" CellSpacing="2" BorderColor="#ffffff">
>>>>>>> f5b2f58c65e2f1be7127c61681d6ce3f5ca04d64
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Height="30px" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
<<<<<<< HEAD
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" Height="30px" />
=======
            <RowStyle BackColor="#FFFF99" ForeColor="#333333" Height="30px" />
>>>>>>> f5b2f58c65e2f1be7127c61681d6ce3f5ca04d64
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <sortedascendingcellstyle backcolor="#FDF5AC" />
            <sortedascendingheaderstyle backcolor="#4D0000" />
            <sorteddescendingcellstyle backcolor="#FCF6C0" />
            <sorteddescendingheaderstyle backcolor="#820000" />

        </asp:GridView>

    </div>


                

                <%-- END REPORTS MENU --%>
</asp:Content>

