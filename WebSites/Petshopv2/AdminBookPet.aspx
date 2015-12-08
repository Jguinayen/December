<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminBookPet.aspx.cs" Inherits="AdminBookPet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3>Book an Appointment</h3></td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
           
    </table>
        <br />



    <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <%--<tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3>Book Now</h3></td>
                <td class="auto-style7">[Customer ID]</td>
                <td class="auto-style7">
                    [Booking No.]</td>
            </tr>--%>
           <tr style="background-color: #e8dede;">
                <td class="auto-style8" colspan="5">&nbsp;</td>
           </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style5">No. of Pets</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList7" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">Groomer</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem>Groomer 1</asp:ListItem>
                        <asp:ListItem>Groomer 2</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    </td>
            </tr>
            <tr>
                <td style="height:40px" class="auto-style9">&nbsp;</td>
                <td class="auto-style5"></td>
                <td class="auto-style10" colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="Book an Appointment" Width="154px" />
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" Width="113px" />
                &nbsp;&nbsp;</td>
            </tr>
        <tr style="background-color: #e8dede;">
                <td colspan="5">&nbsp;</td>
           </tr>
        </table>

    <br />


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

