<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminInvoice.aspx.cs" Inherits="AdminInvoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

        <p id="pagetitle">Invoice</p>
    <table style="width:100%; background-color: #e8dede; padding: 4px 4px 4px 4px;">
            <tr style="background-color: #e8dede;">
                <td style="vertical-align:top;">

        <!------ Invoice Table ------>
        
                    <table style="width: 80%; margin: 4px 4px 0px 20px;" class="center-block" cellspacing="4px" cellpadding="2px">
                        <tr>
                            <td style="width: 120px; font-size:14px;">
                                Date </td>
                            <td class="auto-style1"><asp:TextBox ID="TXTBXINVDATE" runat="server" Width="115px"></asp:TextBox></td>
                            <td class="auto-style34">&nbsp;</td>
                            <td class="auto-style34">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 120px; font-size:14px;"><%--Customer Name--%> Customer:</td>
                            <td class="auto-style1" style="text-align:left;">
                                <%-- ID #--%><asp:TextBox ID="TXTBXCUSTOMERNAME" runat="server" AutoPostBack="True" OnTextChanged="TXTBXCUSTOMERNAME_TextChanged"></asp:TextBox>
                            </td>
                            <td>
                                Customer ID:</td>
                            <td>
                                <asp:Label ID="LBLCUSTID" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style1">
                                <asp:Label ID="LBLMESS" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        </table>
                  
                    <br />

        <!------ Invoice Table ------>
                    
                    <table id="invoice" style="width: 90%; table-layout:fixed;" class="center-block">
                        <tr>
                            <th style="width: 10%;">Delete</th>
                            <th style="width: 40%;">Job Type</th>
                            <th style="width: 15%;">Qty</th>
                            <th style="width: 15%;">Price</th>
                            <th style="width: 15%;">Total</th>
                        </tr>
                        <tr class="alt">
                            <td>
                                GROOM</td>
                            <td></td>
                            <td>
                                </td>
                            <td>
                                </td>
                            <td>
                                </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKFULLGROOM" runat="server" OnCheckedChanged="CHKFULLGROOM_CheckedChanged" AutoPostBack="True"  />
                            </td>
                            <td>Standard Full groom</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYFGROOM" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPFGROOM" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td class="auto-style26">
                                <asp:TextBox ID="TXTBXTFGROOM" runat="server" Width="60px" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKPLATINUM" runat="server" AutoPostBack="True" OnCheckedChanged="CHKPLATINUM_CheckedChanged" />
                            </td>
                            <td>Platinum</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYPLAT" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPPLAT" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTPLAT" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKGOLD" runat="server" AutoPostBack="True" OnCheckedChanged="CHKGOLD_CheckedChanged" />
                            </td>
                            <td>Gold</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYGOLD" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPGOLD" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTGOLD" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKMINI" runat="server" AutoPostBack="True" OnCheckedChanged="CHKMINI_CheckedChanged"  />
                            </td>
                            <td>Mini</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYMINI" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPMINI" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTMINI" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td>
                                SHAMPOO</td>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKSHAMPOO" runat="server" AutoPostBack="True" OnCheckedChanged="CHKSHAMPOO_CheckedChanged" />
                            </td>
                            <td>&nbsp;Standard Shampoo</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYSHAMPOO" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPSHAMPOO" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTSHAMPOO" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKWASHBLOW" runat="server" AutoPostBack="True" OnCheckedChanged="CHKWASHBLOW_CheckedChanged" />
                            </td>
                            <td>Wash &amp; Blow Dry</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYWB" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPWB" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTWB" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKCALMING" runat="server" AutoPostBack="True" OnCheckedChanged="CHKCALMING_CheckedChanged" />
                            </td>
                            <td>Calming Canine Shampoo Treatment</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYCALMING" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPCALMING" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTCALMING" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKCITRUS" runat="server" AutoPostBack="True" OnCheckedChanged="CHKCITRUS_CheckedChanged" />
                            </td>
                            <td>Citrus Sensation Shampoo Treatment</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYCITRUS" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPCITRUS" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTCITRUS" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKSMOOTHIE" runat="server" AutoPostBack="True" OnCheckedChanged="CHKSMOOTHIE_CheckedChanged" />
                            </td>
                            <td>Super Smoothie</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYSMOOTHIE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPSMOOTHIE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTSMOOTHIE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKFLEARELIEF" runat="server" AutoPostBack="True" OnCheckedChanged="CHKFLEARELIEF_CheckedChanged" />
                            </td>
                            <td>Flea Relief</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYFLEA" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPFLEA" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTFLEA" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKKISSABLE" runat="server" AutoPostBack="True" OnCheckedChanged="CHKKISSABLE_CheckedChanged" />
                            </td>
                            <td>Kissable Dog</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYKISS" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPKISS" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTKISS" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
        

                        <tr class="alt">
                            <td>
                                OTHERS</td>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKDYE" runat="server" AutoPostBack="True" OnCheckedChanged="CHKDYE_CheckedChanged" />
                            </td>
                            <td>Dye</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYDYE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPDYE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTDYE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKCUT" runat="server" AutoPostBack="True" OnCheckedChanged="CHKCUT_CheckedChanged" />
                            </td>
                            <td>Cut</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYCUT" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPCUT" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTCUT" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKNAILTRIM" runat="server" AutoPostBack="True" OnCheckedChanged="CHKNAILTRIM_CheckedChanged" />
                            </td>
                            <td>Nail Trim Only</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYNAILTRIM" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPNAILTRIM" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTNAILTRIM" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKPEDICURE" runat="server" AutoPostBack="True" OnCheckedChanged="CHKPEDICURE_CheckedChanged" />
                            </td>
                            <td>Perfect Pedicure</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYPEDICURE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPPEDICURE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTPEDICURE" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKFACIAL" runat="server" AutoPostBack="True" OnCheckedChanged="CHKFACIAL_CheckedChanged" />
                            </td>
                            <td>Facial</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYFACIAL" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPFACIAL" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTFACIAL" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="CHKSHEDDING" runat="server" AutoPostBack="True" OnCheckedChanged="CHKSHEDDING_CheckedChanged" />
                            </td>
                            <td>De-Shedding</td>
                            <td>
                                <asp:TextBox ID="TXTBXQTYSHEDDING" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXPSHEDDING" runat="server" Width="60px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TXTBXTSHEDDING" runat="server" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="height:50px" class="alt">
                            <td colspan="5" class="text-center">
                                <asp:Button ID="BTNUPDATEINVOICE" runat="server" Text="Preview Invoice" OnClick="BTNUPDATEINVOICE_Click" />
                                &nbsp;</td>
                        </tr>
                        </table>
                    <br />
                    
                    
                </td>

                <td class="auto-style16" style="vertical-align:top;">

                     <!----------RECEIPT PREVIEW--------------->
                    <div id="centertable">
                        <h5 class="text-center">INVOICE PREVIEW
                            </h5>
                    <table class="centerbutton" style="background-color: aliceblue; width: 300px; border: solid 1px black; height:500px;">
                        
                        <tr>
                            <td class="text-center" style="vertical-align:top; height:70px;">
                                <h4>PETSHOPPE
                                    </h4><h6>20 Hobson street,
                                <br />
                                Auckland CBD, New Zealand<br />
                                (+64) 12345678</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style18" style="height:25px;">
                                <h6 class="text-center">&nbsp;Invoice #
                                    <asp:Label ID="Label1" runat="server" Text="LBLINVNO"></asp:Label>
&nbsp;21-11-2015 12:18 pm</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td style="align-items:center; vertical-align:top;">
                                
                                    <asp:GridView ID="GRDINVOICE" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" style="width:95%; margin-left: 10px;" OnRowDataBound="GRDINVOICE_RowDataBound" ShowFooter="True">
                                        <Columns>
                                            <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                                            <asp:BoundField DataField="JobType" HeaderText="JobType" SortExpression="JobType" />
                                            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                                            <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Qty], [JobType], [UnitPrice], [TotalPrice] FROM [InvoiceTemp] WHERE ([CustomerID] = @CustomerID)">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="LBLCUSTID" Name="CustomerID" PropertyName="Text" Type="String" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                
                           
                                 </td>
                            
                        </tr>
                        
                        
                        <tr style="height:50px;">
                            <td class="auto-style13"  style="font: bold 12px arial, verdana;text-align:center; ">Thank you,
                                Come Again<br />
                                We appreciate your Business</td>
                        </tr>
                        
                        
                    </table>

                    <br />
                    <asp:Button ID="BTNPRINTINVOICE" CssClass="center-block" runat="server" Text="Print Invoice" OnClick="BTNPRINTINVOICE_Click" />
                    </div>
                    <br />
             <!----------/RECEIPT PREVIEW--------------->

                </td>

                <td class="auto-style16" style="vertical-align:top;">

                     &nbsp;</td>
            </tr>
           
              
            </table>


</asp:Content>

