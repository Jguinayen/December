<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminReports.aspx.cs" Inherits="AdminReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

     <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3>Reports - Upcoming Bookings (Today)</h3></td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
           
        </table>
        <br />

    <table style="width: 100%;">
        <tr>
            <td>

                <%-- REPORTS MENU --%>

                <table id="UpcomingTable" style="width: 100%; border: solid 1px black">
                        <tr style="background-color: aliceblue">
                            <td class="auto-style29">&nbsp;</td>
                            <td class="auto-style21">Booking ID</td>
                            <td class="auto-style8">Pet ID</td>
                            <td class="auto-style9">Pet Name</td>
                            <td class="auto-style18">Date</td>
                            <td class="auto-style14">Time</td>
                            <td class="auto-style16" align=center>Options</td>
                        </tr>
                        <tr>
                            <td class="auto-style30">&nbsp;</td>
                            <td class="auto-style23">00045</td>
                            <td class="auto-style24">3115</td>
                            <td class="auto-style25">Oscar</td>
                            <td class="auto-style26" nowrap>05-12-2015</td>
                            <td class="auto-style27">10:00 AM</td>
                            <td class="auto-style28" align=center>
                                <asp:Button ID="Button6" runat="server" Text="Served" />
                            &nbsp;<asp:Button ID="Button1" runat="server" Text="Cancel Appointment" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">&nbsp;</td>
                            <td class="auto-style23">00146</td>
                            <td class="auto-style24">2210</td>
                            <td class="auto-style25">Tuffy</td>
                            <td class="auto-style26" nowrap>05-12-2015</td>
                            <td class="auto-style27">11:00 AM</td>
                            <td class="auto-style28" align=center>
                                <asp:Button ID="Button2" runat="server" Text="Served" />
                            &nbsp;<asp:Button ID="Button7" runat="server" Text="Cancel Appointment" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00367</td>
                            <td class="auto-style12">0216</td>
                            <td class="auto-style20">Aki</td>
                            <td class="auto-style19" nowrap>05-12-2015</td>
                            <td class="auto-style15">01:00 PM</td>
                            <td class="auto-style28" align=center>
                                <asp:Button ID="Button3" runat="server" Text="Served" />
                            &nbsp;<asp:Button ID="Button8" runat="server" Text="Cancel Appointment" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00523</td>
                            <td class="auto-style12">3519</td>
                            <td class="auto-style20">Charlie</td>
                            <td class="auto-style19" nowrap>05-12-2015</td>
                            <td class="auto-style15">02:00 PM</td>
                            <td class="auto-style28" align=center>
                                <asp:Button ID="Button4" runat="server" Text="Served" />
                            &nbsp;<asp:Button ID="Button9" runat="server" Text="Cancel Appointment" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00851</td>
                            <td class="auto-style12">0018</td>
                            <td class="auto-style20">Kukai</td>
                            <td class="auto-style19" style="width:auto;">05-12-2015</td>
                            <td class="auto-style15">02:00 PM</td>
                            <td class="auto-style28" style="text-align:center;">
                                <asp:Button ID="Button5" runat="server" Text="Served" />
                            &nbsp;<asp:Button ID="Button10" runat="server" Text="Cancel Appointment" />
                            </td>
                        </tr>
                                                
                    </table>

                <%-- END REPORTS MENU --%>

            </td>
            <td>&nbsp;</td>

        </tr>


    </table>

</asp:Content>

