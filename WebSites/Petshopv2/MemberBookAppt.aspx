﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="MemberBookAppt.aspx.cs" Inherits="MemberBookAppt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <%---------------- CALENDAR --------------------%>

     <p id="pagetitle">Book an Appointment</p>
    
    
     <%---------------- END OF CALENDAR --------------------%>

    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
           
           <tr>
                <td style="height: 24px"></td>
                <td style="width:100px; height: 24px;">No. of Pets</td>
                <td class="auto-style6" style="height: 24px">
                    <asp:DropDownList ID="DRPPETNUMBER" runat="server" OnSelectedIndexChanged="DRPPETNUMBER_SelectedIndexChanged1">
                        <asp:ListItem>Please Select</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style15" style="height: 24px"></td>
                <td class="auto-style16" style="height: 24px">
                    </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">Branch</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="DRPBRANCH" runat="server" OnSelectedIndexChanged="DRPBRANCH_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">Groomer</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="DRPGROOMER" runat="server" Enabled="False" OnSelectedIndexChanged="DRPGROOMER_SelectedIndexChanged" >
                    </asp:DropDownList>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    </td>
            </tr>
                    
        </table> <br />

    <%---------------- END NO. OF PETS -------------%>


    <%---------------- CALENDAR --------------------%>

    <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="2" CellPadding="4" Font-Names="Verdana" Font-Size="12pt" ForeColor="Black" Height="600px" NextPrevFormat="FullMonth"  Width="100%" DayNameFormat="Full" ShowGridLines="true" OnDayRender="Calendar2_DayRender" OnSelectionChanged="Calendar2_SelectionChanged">
        <DayHeaderStyle Font-Bold="True" Font-Size="10pt" ForeColor="#333333" Height="5pt" />
        <DayStyle BackColor="#ffffff" />
        <NextPrevStyle Font-Bold="True" Font-Size="12pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#cccccc" />
        <SelectedDayStyle BackColor="#cccccc" ForeColor="White" />
        <TitleStyle BackColor="#333333" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="5pt" />
        <TodayDayStyle BackColor="#cccccc" ForeColor="White" Font-Bold="true" />
    </asp:Calendar>
        
     <%---------------- END OF CALENDAR --------------------%>
    <br />


 


</asp:Content>

