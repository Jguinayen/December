<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="MemberBookAppt.aspx.cs" Inherits="MemberBookAppt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <p id="pagetitle">Book an Appointment</p>
    
    
     <%---------------- NO. OF PETS ----------------%>

    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
         
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                <td class="auto-style7">&nbsp; Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TXTBXDATE" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style5">Customer ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style6" style="width: 80px">
                    <asp:TextBox ID="TXTBXCUSTOMERID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">&nbsp;Customer Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="TXTBXCUSTOMERNAME" runat="server"></asp:TextBox></td>
                <td class="auto-style16">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style5">No. of Pets</td>
                <td class="auto-style6" style="width: 80px">
                    <asp:DropDownList ID="DRPPETNUMBER" runat="server">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">Branch</td>
                <td class="auto-style12" style="width: 80px">
                    <asp:DropDownList ID="DRPBRANCH" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DRPBRANCH_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp; Groomer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:DropDownList ID="DRPGROOMER" runat="server">
                    </asp:DropDownList>
                    </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="height:40px" class="auto-style9">&nbsp;</td>
                <td class="auto-style5"></td>
                <td class="auto-style10" colspan="3">
                    <asp:Button ID="BTNBOOK" runat="server" Text="Book an Appointment" Width="154px" OnClick="BTNBOOK_Click" />
                    &nbsp;<asp:Button ID="BTNCANCEL" runat="server" Text="Cancel" Width="113px" />
                &nbsp;&nbsp;</td>
            </tr>
      
        </table> <br />

    <%---------------- END NO. OF PETS -------------%>


    <%---------------- CALENDAR --------------------%>

    <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="2" CellPadding="4" Font-Names="Verdana" Font-Size="12pt" ForeColor="Black" Height="600px" NextPrevFormat="FullMonth"  Width="100%" DayNameFormat="Full" ShowGridLines="true">
        <DayHeaderStyle Font-Bold="True" Font-Size="10pt" ForeColor="#333333" Height="5pt" />
        <DayStyle BackColor="#ffffff" />
        <NextPrevStyle Font-Bold="True" Font-Size="12pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#cccccc" />
        <SelectedDayStyle BackColor="#cccccc" ForeColor="White" />
        <TitleStyle BackColor="#333333" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="5pt" />
        <TodayDayStyle BackColor="#cccccc" ForeColor="White" Font-Bold="true" />
    </asp:Calendar>
        
     <%---------------- CALENDAR --------------------%>
    <br />

    <!--with TIME-->
    
    <table id="daytable" border="0" width="100%" cellspacing="2" cellpadding="10px" style="background-color:#ffffff;">

<tr style="background-color:#ffffff;"><td style="height: 39px;">Friday 27 November 2015</td></tr>

<tr><td>Time</td></tr>

<tr><td><a href="#">09:00 a.m.</a></td></tr>

<tr><td><a href="#">10:00 a.m.</a></td></tr> 
        
<tr><td><a href="#">11:00 a.m.</a></td></tr>  

<tr><td><a href="#">12:00 p.m.</a></td></tr>

<tr><td><a href="#">01:00 p.m.</a></td></tr> 
        
<tr><td><a href="#">02:00 p.m.</a></td></tr>
        
<tr><td><a href="#">03:00 p.m.</a></td></tr>

<tr><td><a href="#">04:00 p.m.</a></td></tr> 
        
<tr><td><a href="#">05:00 p.m.</a></td></tr>             
    
    </table>
       
<!--end with TIME--> 


</asp:Content>

