<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="MemberUpcoming.aspx.cs" Inherits="MemberUpcoming" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <p id="pagetitle">Upcoming Bookings</p>
    
    <table style="width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
   
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
                            <td class="auto-style24">3215</td>
                            <td class="auto-style25">Oscar</td>
                            <td class="auto-style26" nowrap>10-11-2015</td>
                            <td class="auto-style27">10:00 AM</td>
                            <td class="auto-style28" align=center>
                                <asp:Button ID="Button6" runat="server" Text="Cancel" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">&nbsp;</td>
                            <td class="auto-style23">00146</td>
                            <td class="auto-style24">3215</td>
                            <td class="auto-style25">Oscar</td>
                            <td class="auto-style26" nowrap>30-12-2015</td>
                            <td class="auto-style27">10:00 AM</td>
                            <td class="auto-style28" align=center>
                                <asp:Button ID="Button7" runat="server" Text="Cancel" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00367</td>
                            <td class="auto-style12">3215</td>
                            <td class="auto-style20">Oscar</td>
                            <td class="auto-style19" nowrap>24-12-2015</td>
                            <td class="auto-style15">10:00 AM</td>
                            <td class="auto-style17" align=center>
                                <asp:Button ID="Button8" runat="server" Text="Cancel" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00523</td>
                            <td class="auto-style12">3215</td>
                            <td class="auto-style20">Oscar</td>
                            <td class="auto-style19" nowrap>10-01-2016</td>
                            <td class="auto-style15">10:00 AM</td>
                            <td class="auto-style17" align=center>
                                <asp:Button ID="Button9" runat="server" Text="Cancel" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00851</td>
                            <td class="auto-style12">3215</td>
                            <td class="auto-style20">Oscar</td>
                            <td class="auto-style19" nowrap>14-02-2016</td>
                            <td class="auto-style15">10:00 AM</td>
                            <td class="auto-style17" align=center>
                                <asp:Button ID="Button10" runat="server" Text="Cancel" />
                            </td>
                        </tr>
                                                
                    </table>




</asp:Content>

