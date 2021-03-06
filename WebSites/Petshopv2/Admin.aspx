﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">
    <p id="pagetitle">Schedule Manager</p>

     <table style="width: 100%; border: 1px solid #000; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr>
                <td style="width: 91px;" class="input-medium">
                    <asp:Label ID="lblAdminCalID" runat="server" Text=""></asp:Label>
                </td>
                <td><h4>Holidays and Groomer&#39;s Day Off </h4></td>
            </tr>
            <tr>

                <td class="auto-style9" style="width: 91px; height: 36px;">&nbsp;&nbsp;

                    <asp:Label ID="lblAdminCalName" runat="server" Text="Name"></asp:Label>
                   
                </td>
                <td class="auto-style9" style="height: 36px;">
                    <asp:TextBox ID="txtAdminCalName" runat="server" Width="50%"></asp:TextBox>
                </td>
            </tr>
            <tr>

                <td style="width: 150px; height: 20px;">&nbsp;&nbsp;

               
                    <asp:Label ID="lblAdminCalBlockDate" runat="server" Text="Blocked Date"></asp:Label>
                </td>
                <td style="height: 20px;">
                    <asp:TextBox ID="txtAdminCalBlockDate" runat="server" Width="50%"></asp:TextBox>
                </td>
            </tr>
            <tr>

                <td style="width: 91px; height: 36px;">&nbsp;&nbsp;
                    <asp:Label ID="lblAdminCalNotes" runat="server" Text="Notes"></asp:Label>
                </td>
                <td style="height: 36px;">
                    <asp:TextBox ID="txtAdminCalNotes" runat="server" Width="50%"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td style="height:40px; width: 91px;" class="auto-style9">
                    &nbsp;</td>
                <td style="height:40px; font: 12px; text-align:left;">
                    
                    <table style="width:700px;">
                        <tr>
                            <td>
                                <asp:Button ID="btnAdminCalBlockDates" Font-Size="14px" Height="35px" runat="server" Text="Block Dates" Width="100px" OnClick="btnAdminCalBlockDates_Click" CssClass="btn btn-primary" />
                                <asp:Button ID="btnAdminCalViewBlockDates" Font-Size="14px" Height="35px"  runat="server" Text="View Blocked Dates" Width="175px" OnClick="btnAdminCalViewBlockDates_Click" CssClass="btn btn-primary" /><asp:Button ID="btnAdminCalEdit" Font-Size="14px" Height="35px"  runat="server" Text="Edit" Width="90px" OnClick="btnAdminCalEdit_Click" CssClass="btn btn-primary" /><asp:Button ID="btnAdminCalSaveChanges" Font-Size="14px" Height="35px"  runat="server" Text="Save Changes" Width="120px" OnClick="btnAdminCalSaveChanges_Click" CssClass="btn btn-success" /></td>
                           
                        </tr>
                        
                    </table>
                    </td>
            </tr>
            <tr>
                <td style="height:10px; width: 91px;" class="auto-style9">
                    &nbsp;</td>
                <td style="height:10px; font: 12px;" class="auto-style9">
                    &nbsp;</td>
            </tr>
        </table>

    <br />

    

    
     <asp:GridView ID="grdviewAdminCalendar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="both" Width="100%" OnSelectedIndexChanged="grdviewAdminCalendar_SelectedIndexChanged">
         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
         <Columns>
             <asp:CommandField ShowSelectButton="True" />
         </Columns>
         <EditRowStyle BackColor="#999999" />
         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Height="30px" />
         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Height="30px" Font-Size="14px" />
         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#E9E7E2" />
         <SortedAscendingHeaderStyle BackColor="#506C8C" />
         <SortedDescendingCellStyle BackColor="#FFFDF8" />
         <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
     </asp:GridView>

    

    
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="white" BorderColor="Black" BorderWidth="2" BorderStyle="solid" CellSpacing="2" CellPadding="4" Font-Names="Verdana" Font-Size="12pt" ForeColor="Black" Height="600px" NextPrevFormat="FullMonth" Width="100%" DayNameFormat="Full" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged" ShowGridLines="True">

        <DayHeaderStyle Font-Bold="True" Font-Size="10pt" ForeColor="#333333" Height="5pt" />
        <DayStyle BackColor="#ffffff" />
        <NextPrevStyle Font-Bold="True" Font-Size="12pt" ForeColor="white" />
        <OtherMonthDayStyle ForeColor="#cccccc" />
        <SelectedDayStyle BackColor="#cccccc" ForeColor="White" />
        <%--<TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="25pt" />--%>
        <TitleStyle BackColor="#333333" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="30pt" Font-Names="Arial" />
        <TodayDayStyle BackColor="#cccccc" ForeColor="White" Font-Bold="True" />
    </asp:Calendar>
    
    <br /><br />
     <!--with TIME-->
    
<!--end with TIME-->  

</asp:Content>

