<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="Invoice.aspx.cs" Inherits="Invoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>


    <link rel="stylesheet" href="components/bootstrap2/css/bootstrap.css"/>
 <link rel="stylesheet" href="components/bootstrap2/css/bootstrap-responsive.css"/>
 <link rel="stylesheet" href="css/calendar.css"/>
    <style type="text/css">
        .auto-style2 {
            width: 106px;
        }
        .auto-style4 {
            width: 55px;
            text-align: center;
        }
        .auto-style7 {
            width: 60%;
            height: 23px;
        }
        .auto-style12 {
            width: 60%;
        }
        .auto-style16 {
            width: 335px;
        }
                
        /*------table style-----*/

#invoice {
    font-family: Arial, Helvetica, sans-serif;
    width: 100%;
    border-collapse: collapse;
}

#invoice td, #invoice th {
    font-size: 12px;
    border: 2px solid #efefef;
    padding: 4px 7px 4px 7px;
}

#invoice th {
    font-size: 12px;
    text-align: left;
    padding-top: 5px;
    padding-bottom: 4px;
    background-color: #FFCC00;
    color: #333333;
}

        #invoice tr.alt td {
            color: #000000;
            background-color: #e0e0e0;
        }


/* ---- table style --- */

        .auto-style23 {
            width: 64px;
        }

        .auto-style24 {
            width: 55px;
            text-align: center;
            height: 30px;
        }
        .auto-style26 {
            height: 30px;
            width: 50px;
        }
        .auto-style27 {
            width: 802px;
        }
        .auto-style28 {
            width: 802px;
            height: 30px;
        }

        .auto-style29 {
            width: 50px;
        }
        
        .auto-style30 {
            width: 124px;
        }
        .auto-style31 {
            width: 124px;
            height: 30px;
        }
        .auto-style32 {
            width: 106px;
            height: 30px;
        }
        
        .auto-style33 {
            width: 55px;
        }
        
     </style>


   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br /><br /><br /><br /><br />
    <div class="container">

        <!-- TOP MEMBER NAVBAR-->
        <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">Hi, Admin</a>
    </div>
    <div>
      <ul class="nav navbar-nav">
        <li><a href="Admin.aspx">Calendar</a></li>
        <li><a href="DateSettings.aspx">Date Settings</a></li>
        <li><a href="UserAccts.aspx">User Accounts</a></li>
        <li><a href="Reports.aspx">Reports</a></li>
        <li><a href="Account.aspx">My Account</a></li>
        <li class="active"><a href="Invoice.aspx">Invoice</a></li>
          <li><a href="BookPet.aspx">Book an Appointment</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
       <%--<li><a href="#"><span class="glyphicon glyphicon-log-out"></span> Logout</a></li>--%>
      </ul>
    </div>
  </div>
</nav>
       <!-- /TOP MEMBER NAVBAR-->


    <table style="border: 1px solid #000; width:100%; background-color: #e8dede; padding: 4px 4px 4px 4px;">
            <tr style="background-color: #e8dede; height: 20px;">
                <td class="auto-style12"><h3>Invoice&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date:
                            <asp:TextBox ID="TXTBXDATE" runat="server" Width="105px"></asp:TextBox>
                    </h3></td>
                <td class="auto-style16" rowspan="2" style="vertical-align:top;">

                     <!----------RECEIPT PREVIEW--------------->
                    <div id="centertable">
                        <h5>INVOICE PREVIEW&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </h5>
                    <table class="centerbutton" style="background-color: aliceblue; width: 95%; border: solid 1px black">
                        
                        <tr>
                            <td class="auto-style18">
                                <h4>PETSHOPPE
                                    </h4><h6>20 Hobson street,
                                <br />
                                Auckland CBD, New Zealand<br />
                                (+64) 12345678</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style18">
                                <h6>&nbsp;Invoice #
                                    <asp:Label ID="Label1" runat="server" Text="LBLINVNO"></asp:Label>
&nbsp;21-11-2015 12:18 pm</h6>
                            </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style23">
                                <asp:GridView ID="INVPARTICULARS" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Width="308px">
                                    <Columns>
                                        <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                                        <asp:BoundField DataField="DESCRIPTION" HeaderText="DESCRIPTION" SortExpression="DESCRIPTION" />
                                        <asp:BoundField DataField="UPRICE" HeaderText="UPRICE" SortExpression="UPRICE" />
                                        <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
                                    </Columns>
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [QTY], [DESCRIPTION], [UPRICE], [Total] FROM [Particulars] WHERE ([CustomerID] = @CustomerID)">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="CustomerID" SessionField="CustomerID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                            
                        </tr>
                        
                        
                        <tr height="50px">
                            <td class="auto-style13" align="center" style="font: bold 12px arial, verdana;">Thank you,
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
                <td class="auto-style7" style="vertical-align:top;">

        <!------ Invoice Table ------>
        
                    <table style="width: 100%;">
                        <tr>
                            <td>Customer Name</td>
                            <td>
                                <asp:TextBox ID="TXTBXCUSTNAME" runat="server"></asp:TextBox>&nbsp;&nbsp; ID #:<asp:TextBox ID="TXTBXCUSTID" runat="server"  Width="111px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        
                    </table>


        <!------ Invoice Table ------>

                    <table id="invoice" style="width: 100%; border: solid 2px white">
                        <tr>
                            <th style="text-align:center;" class="auto-style33">Delete</td>
                            <th class="auto-style27">Job Type
                            <th class="auto-style2">Qty
                            <th class="auto-style30">Price</td>
                            <th class="auto-style29">Total</td>
                        </tr>
                        <tr>
                            <td class="auto-style24">
                                GROOM</td>
                            <td class="auto-style28"></td>
                            <td class="auto-style32">
                                </td>
                            <td class="auto-style31">
                                </td>
                            <td class="auto-style26" nowrap>
                                </td>
                        </tr>
                        <tr>
                            <td class="auto-style24">
                                <asp:CheckBox ID="CHKFULLGROOM" runat="server"  />
                            </td>
                            <td class="auto-style28">Standard Full groom</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYFGROOM" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPFGROOM0" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTFGROOM" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKPLATINUM" runat="server" />
                            </td>
                            <td class="auto-style27">Platinum</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYPLAT" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPPLAT" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTPLAT" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKGOLD" runat="server" />
                            </td>
                            <td class="auto-style27">Gold</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYGOLD" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPGOLD" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTGOLD" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKMINI" runat="server" />
                            </td>
                            <td class="auto-style27">Mini</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYMINI" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPMINI" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTMINI" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                SHAMPOO</td>
                            <td class="auto-style27">&nbsp;</td>
                            <td class="auto-style32">
                                &nbsp;</td>
                            <td class="auto-style31">
                                &nbsp;</td>
                            <td class="auto-style26" nowrap>
                                &nbsp;</td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKSHAMPOO" runat="server" />
                            </td>
                            <td class="auto-style27">&nbsp;Standard Shampoo</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYSHAMPOO" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPSHAMPOO" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTSHAMPOO" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKWASHBLOW" runat="server" />
                            </td>
                            <td class="auto-style27">Wash &amp; Blow Dry</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYWB" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPWB" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTWB" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKCALMING" runat="server" />
                            </td>
                            <td class="auto-style27">Calming Canine Shampoo Treatment</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYCALMING" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPCALMING" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTCALMING" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKCITRUS" runat="server" />
                            </td>
                            <td class="auto-style27">Citrus Sensation Shampoo Treatment</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYCITRUS" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPCITURS" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTCITRUS" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKSMOOTHIE" runat="server" />
                            </td>
                            <td class="auto-style27">Super Smoothie</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYSMOOTHIE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPSMOOTHIE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTSMOOTHIE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKFLEARELIEF" runat="server" />
                            </td>
                            <td class="auto-style27">Flea Relief</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYFLEA" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPFLEA" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTFLEA" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style24">
                                <asp:CheckBox ID="CHKKISSABLE" runat="server" />
                            </td>
                            <td class="auto-style28">Kissable Dog</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYKISS" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPKISS" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTKISS" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
        

                        <tr>
                            <td class="auto-style4">
                                OTHERS</td>
                            <td class="auto-style27">&nbsp;</td>
                            <td class="auto-style32">
                                &nbsp;</td>
                            <td class="auto-style31">
                                &nbsp;</td>
                            <td class="auto-style26" nowrap>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKDYE" runat="server" />
                            </td>
                            <td class="auto-style27">Dye</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYDYE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPDYE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTDYE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr class="alt">
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKCUT" runat="server" />
                            </td>
                            <td class="auto-style27">Cut</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYCUT" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPCUT" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTCUT" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKNAILTRIM" runat="server" />
                            </td>
                            <td class="auto-style27">Nail Trim Only</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYNAILTRIM" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPNAILTRIM" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTNAILTRIM" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKPEDICURE" runat="server" />
                            </td>
                            <td class="auto-style27">Perfect Pedicure</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYPEDICURE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPPEDICURE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTPEDICURE" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:CheckBox ID="CHKFACIAL" runat="server" />
                            </td>
                            <td class="auto-style27">Facial</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYFACIAL" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPFACIAL" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTFACIAL" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4" >
                                <asp:CheckBox ID="CHKSHEDDING" runat="server" />
                            </td>
                            <td class="auto-style27">De-Shedding</td>
                            <td class="auto-style32">
                                <asp:TextBox ID="TXTBXQTYSHEDDING" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style31">
                                <asp:TextBox ID="TXTBXPSHEDDING" runat="server" Width="40px"></asp:TextBox>
                            </td>
                            <td class="auto-style26" nowrap>
                                <asp:TextBox ID="TXTBXTSHEDDING" runat="server" Width="40px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr height="50px" class="alt">
                            <td class="auto-style21;" colspan="2">
                                <asp:Button ID="Button1" runat="server" Text="Update Invoice" />
                                &nbsp;</td>
                            <td class="auto-style2">
                                &nbsp;</td>
                            <td class="auto-style30">
                                &nbsp;</td>
                            <td class="auto-style29" nowrap>
                                &nbsp;</td>
                        </tr>
                        
                    </table>
                    <br />
                    
                    <br />
                </td>
            </tr>
              
            </table>


    </div>
    
    
</asp:Content>

