<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    <link rel="stylesheet" href="components/bootstrap2/css/bootstrap.css"/>
 <link rel="stylesheet" href="components/bootstrap2/css/bootstrap-responsive.css"/>

    <style type="text/css">
        .auto-style1 {
            width: 7px;
        }
        .auto-style2 {
            width: 14px;
        }
        .auto-style3 {
            width: 15px;
        }
        .auto-style4 {
            width: 313px;
        }
        .auto-style5 {
            width: 10px;
        }
        .auto-style6 {
            width: 98px;
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
      <a class="navbar-brand" href="#">Hi, Johana</a>
    </div>
    <div>
      <ul class="nav navbar-nav">
        <li><a href="booknow.aspx">Book Now</a></li>
        <li><a href="UpcomingBook.aspx">Upcoming Bookings</a></li>
        <li><a href="CancelledBookings.aspx">Cancelled Bookings</a></li>
        <li><a href="TransHistory.aspx">Transaction History</a></li>
        <li><a href="RegisterMyPet.aspx">Register My Pet</a></li>
        <li class="active"><a href="MyAccount.aspx">My Account</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
          <%--<li><a href="#"><span class="glyphicon glyphicon-log-out"></span> Logout</a></li>--%>
      </ul>
    </div>
  </div>
</nav>
       <!-- /TOP MEMBER NAVBAR-->


        
        <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7" colspan="4"><h3>My Account</h3></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">
                    Customer ID</td>
                
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXCUSTOMID" runat="server"></asp:TextBox>
                </td>
                
                <td class="auto-style6">Membership Date</td>
                
                <td class="auto-style15">
                    <asp:TextBox ID="TXTBXMEMDATE" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">
                    Lastname</td>
                
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXLNAME" runat="server" Width="205px"></asp:TextBox>
                </td>
                
                <td class="auto-style6">Username</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXUNAME" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Firstname</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXFNAME" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXPWORD" runat="server"></asp:TextBox>
                 </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Mobile</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXMOBILE" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXEMAIL" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">Address</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXADD" runat="server" Height="50px" TextMode="MultiLine" Width="280px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Button ID="BTNREGISTER" runat="server" Text="Register" Width="154px" OnClick="BTNREGISTER_Click" />
                    &nbsp;<asp:Button ID="BTNCANCEL" runat="server" Text="Cancel" Width="113px" />
                    <br />
                    <br />
                    <br />
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="LBLMSG" runat="server" Text="Label"></asp:Label>
                </td>
                
            </tr>
            </table>

    </div>

    <center>
 
    <!-- /Forms -->
        <p></p><p></p>

    </center>

</asp:Content>