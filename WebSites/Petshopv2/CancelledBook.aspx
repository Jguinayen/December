<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="CancelledBook.aspx.cs" Inherits="CancelledBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">


    <table id="CancelTable" style="border: 1px; width: 100%; background-color: #e8dede; padding: 4px 4px 4px 4px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style32"></td>
                <td class="auto-style33" colspan="4"><h3>Cancelled Bookings</h3></td>
            </tr>
            <tr style="background-color: #e8dede;">
                <td class="auto-style3">&nbsp;</td>
                <td style="width: 100%" class="auto-style7" colspan="4">

                    <table style="width: 98%; border: solid 1px black">
                        <tr style="background-color: aliceblue">
                            <td class="auto-style29">&nbsp;</td>
                            <td class="auto-style21">Booking ID</td>
                            <td class="auto-style8">Pet ID</td>
                            <td class="auto-style9">Pet Name</td>
                            <td class="auto-style18">Date</td>
                            <td class="auto-style14">Time</td>
                            <td class="auto-style16">Reason</td>
                        </tr>
                        <tr>
                            <td class="auto-style30">&nbsp;</td>
                            <td class="auto-style23">00045</td>
                            <td class="auto-style24">3215</td>
                            <td class="auto-style25">Oscar</td>
                            <td class="auto-style26" nowrap>10-11-2015</td>
                            <td class="auto-style27">10:00 AM</td>
                            <td class="auto-style28" nowrap style="width: 150px;">
                                date re-scheduled
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">&nbsp;</td>
                            <td class="auto-style23">00146</td>
                            <td class="auto-style24">3215</td>
                            <td class="auto-style25">Oscar</td>
                            <td class="auto-style26" nowrap>30-12-2015</td>
                            <td class="auto-style27">10:00 AM</td>
                            <td class="auto-style28">
                                owner unavailable
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00367</td>
                            <td class="auto-style12">3215</td>
                            <td class="auto-style20">Oscar</td>
                            <td class="auto-style19" nowrap>24-12-2015</td>
                            <td class="auto-style15">10:00 AM</td>
                            <td class="auto-style17">
                                re-booking
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00523</td>
                            <td class="auto-style12">3215</td>
                            <td class="auto-style20">Oscar</td>
                            <td class="auto-style19" nowrap>10-01-2016</td>
                            <td class="auto-style15">10:00 AM</td>
                            <td class="auto-style17">
                                owner unavailable
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style31">&nbsp;</td>
                            <td class="auto-style22">00851</td>
                            <td class="auto-style12">3215</td>
                            <td class="auto-style20">Oscar</td>
                            <td class="auto-style19" nowrap>14-02-2016</td>
                            <td class="auto-style15">10:00 AM</td>
                            <td class="auto-style17">
                                owner unavailable
                            </td>
                        </tr>
                                                
                    </table>
                    <br /><br />
                </td>
            </tr>
            
            </table>



</asp:Content>

