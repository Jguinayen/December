<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Groomer.master" AutoEventWireup="true" CodeFile="GroomerInvoice.aspx.cs" Inherits="GroomerInvoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">
    <%-- CONTENT HERE --%>

     <a href="AdminInvoice.aspx">AdminInvoice.aspx</a> <p id="pagetitle">Invoice</p>

       <table style="border: 1px solid #000; width:100%; background-color: #e8dede; padding: 4px 4px 4px 4px;">
            <tr style="background-color: #e8dede; height: 20px;">
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style12"></td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style16" rowspan="2" style="vertical-align:top;">

                     <!----------RECEIPT PREVIEW--------------->
                    <div id="centertable">
                        <h5>CUSTOMER INVOICE</h5>
                    <table class="centerbutton" style="background-color: aliceblue; width: 95%; border: solid 1px black">
                        
                        <tr>
                            <td class="auto-style18" colspan="4">
                                <h4>PETSHOPPE
                                    </h4><h6>20 Hobson street,
                                <br />
                                Auckland CBD, New Zealand<br />
                                (+64) 12345678</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style18" colspan="4">
                                <h6>&nbsp;Invoice #94875&nbsp; 21-11-2015 12:18 pm</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style23">
                                <h6>Item</h6>
                            </td>
                            <td class="auto-style8">
                                <h6>Job Type</h6>
                            </td>
                            <td class="auto-style8">
                                <h6>Qty</h6>
                            </td>
                            <td class="auto-style9">
                                <h6>Total</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style23">00045</td>
                            <td class="auto-style24">Full Groom</td>
                            <td class="auto-style8">
                                <h6>1</h6>
                            </td>
                            <td class="auto-style25">60.00</td>
                           
                        </tr>
                        <tr>
                            <td class="auto-style23">00146</td>
                            <td class="auto-style24">Shampoo</td>
                            <td class="auto-style8">
                                <h6>1</h6>
                            </td>
                            <td class="auto-style25">60.00</td>
                            
                        </tr>
                        
                        
                        <tr>
                            <td class="auto-style23">&nbsp;</td>
                            <td style="text-align:right;">
                                Subtotal</td>
                            <td class="auto-style8">
                                <h6>&nbsp;</h6>
                            </td>
                            <td class="auto-style25">120.00</td>
                            
                        </tr>
                        
                        
                        <tr>
                            <td class="auto-style23">&nbsp;</td>
                            <td style="text-align:right;">
                                GST</td>
                            <td class="auto-style8">
                                &nbsp;</td>
                            <td class="auto-style14">18.00</td>
                        </tr>
                        
                        
                        <tr>
                            <td class="auto-style23">&nbsp;</td>
                            <td style="text-align:right;">
                                Total&nbsp;</td>
                            <td class="auto-style8">
                                <h6>&nbsp;</h6>
                            </td>
                            <td class="auto-style14">138.00</td>
                        </tr>
                        
                        
                        <tr height="50px">
                            <td class="auto-style13" align="center" style="font: bold 12px arial, verdana;" colspan="4">Thank you,
                                Come Again<br />
                                We appreciate your Business</td>
                        </tr>
                        
                        
                    </table>

                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Print Invoice" />
                    </div>
                    <br />
             <!----------/RECEIPT PREVIEW--------------->

                </td>
            </tr>
            <tr style="background-color: #e8dede;">
                <td class="auto-style11" width="20px">&nbsp;</td>
                <td class="auto-style7" style="vertical-align:top;">

        <!------ Invoice Table ------>
        
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 20%;">Customer Name</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="245px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        
                    </table>


        <!------ Invoice Table ------>

                    <table id="invoice" style="width: 100%; border: solid 2px white">
                        <tr>
                            <th style="width:20px; text-align:center;">Delete</td>
                            <th style="width:60%;">Job Type
                            <th style="width:10px;">Qty
                            <th style="width:10px;">Price</td>
                            <th style="width:10px;">Total</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </td>
                            <td class="auto-style2">Full groom</td>
                            <td class="auto-style25">
                                <asp:TextBox ID="TextBox1" runat="server" Width="40px">1</asp:TextBox>
                            </td>
                            <td class="auto-style25">60.00</td>
                            <td class="auto-style26" nowrap>60.00</td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CheckBox2" runat="server" />
                            </td>
                            <td class="auto-style2">Shampoo</td>
                            <td class="auto-style25">
                                <asp:TextBox ID="TextBox10" runat="server" Width="40px">1</asp:TextBox>
                            </td>
                            <td class="auto-style25">60.00</td>
                            <td class="auto-style26" nowrap>60.00</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CheckBox3" runat="server" />
                            </td>
                            <td class="auto-style2">Dye</td>
                            <td class="auto-style25">
                                <asp:TextBox ID="TextBox11" runat="server" Width="40px">1</asp:TextBox>
                            </td>
                            <td class="auto-style25">60.00</td>
                            <td class="auto-style26" nowrap>60.00</td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CheckBox4" runat="server" />
                            </td>
                            <td class="auto-style2">Cut</td>
                            <td class="auto-style25">
                                <asp:TextBox ID="TextBox12" runat="server" Width="40px">1</asp:TextBox>
                            </td>
                            <td class="auto-style25">60.00</td>
                            <td class="auto-style26" nowrap>60.00</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CheckBox5" runat="server" />
                            </td>
                            <td class="auto-style2">Nail Trim Only</td>
                            <td class="auto-style25">
                                <asp:TextBox ID="TextBox13" runat="server" Width="40px">1</asp:TextBox>
                            </td>
                            <td class="auto-style25">60.00</td>
                            <td class="auto-style26" nowrap>60.00</td>
                        </tr>
                        <tr height="50px" class="alt">
                            <td class="auto-style21;" colspan="2">
                                <asp:Button ID="Button1" runat="server" Text="Update Invoice" />
                                &nbsp;</td>
                            <td class="auto-style20">&nbsp;</td>
                            <td class="auto-style20">&nbsp;</td>
                            <td class="auto-style19" nowrap>&nbsp;</td>
                        </tr>
                        
                    </table>
                    <br />
                    
                    <table id="bigbutton" style="width: 100%; border: solid 2px white; background-color: #e1a4a4 text-align: center;">
                        <tr>
                            <td style="background-color: aliceblue" class="auto-style6" colspan="4">
                                <h5>Other Grooming Services</h5>
                            </td>
                        </tr>
                        <tr>
                            <td style="align-content:center;">
                                &nbsp;</td>
                            <td style="text-align:center;">
                                </td>
                            <td style="text-align:center;">
                                </td>
                            <td style="text-align:center;">
                                </td>
                        </tr>
                        <tr>
                            <td class="auto-style22" style="align-content:center;">
                                <button class="button button2">Platinum Groom</button>
                            </td>
                            <td class="auto-style2" style="text-align:center;">
                               <button class="button button2">Gold Groom</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">Standard Groom</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">Top Dog</button></td>
                        </tr>
                        <tr>
                            <td class="auto-style22" style="align-content:center;">
                                <button class="button button2">Super Smoothie</button>
                            </td>
                            <td class="auto-style2" style="text-align:center;">
                               <button class="button button2">Wash &amp; Blow Dry</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">Mini Groom</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">Nail Trim Only</button></td>
                        </tr>
                        <tr>
                            <td class="auto-style22" style="align-content:center;">
                                <button class="button button2">Kissable Dog</button>
                            </td>
                            <td class="auto-style2" style="text-align:center;">
                               <button class="button button2">Flea Relief</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">De-Shedding</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">Calming Canine<br />
                                    Shampoo Treatment</button></td>
                        </tr>
                        <tr>
                            <td class="auto-style22" style="align-content:center;">
                                <button class="button button2">Citrus Sensation<br />Shampoo Treatment</button>
                            </td>
                            <td class="auto-style2" style="text-align:center;">
                               <button class="button button2">Perfect Pedicure</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                <button class="button button2">Facial</button></td>
                            <td class="auto-style2" style="text-align:center;">
                                &nbsp;</td>
                        </tr>
                        </tr>
                        <tr>
                            <td class="auto-style22" style="align-content:center;">
                                &nbsp;</td>
                            <td class="auto-style2" style="text-align:center;">
                                &nbsp;</td>
                            <td class="auto-style2" style="text-align:center;">
                                &nbsp;</td>
                            <td class="auto-style2" style="text-align:center;">
                                &nbsp;</td>
                        </tr>
                                                                        
                    </table>
                    <br />
                </td>
                <td class="auto-style15" valign="top" align="left">

                    &nbsp;</td>
            </tr>
              
            </table>

</asp:Content>

