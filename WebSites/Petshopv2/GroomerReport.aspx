<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Groomer.master" AutoEventWireup="true" CodeFile="GroomerReport.aspx.cs" Inherits="GroomerReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <p id="pagetitle">Booked Appointments Today</p>

 <%-- REPORTS MENU --%>

     <div style="font: normal 12px arial;">

        <asp:Button ID="Button1" runat="server" Text="Export to Excel" OnClick="Button1_Click" />
        <br /><br />
    

        <asp:GridView ID="GroomerUpcoming" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Both" Width="100%" BorderWidth="2" CellSpacing="2" BorderColor="#ffffff">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Size="Small" Font-Bold="True" ForeColor="White" Height="30px" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" Font-Size="Small" ForeColor="#333333" Height="30px" />

            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <sortedascendingcellstyle backcolor="#FDF5AC" />
            <sortedascendingheaderstyle backcolor="#4D0000" />
            <sorteddescendingcellstyle backcolor="#FCF6C0" />
            <sorteddescendingheaderstyle backcolor="#820000" />

        </asp:GridView>

    </div>


    <%-- END REPORTS MENU --%>


</asp:Content>

