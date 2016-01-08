<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="BookPet.aspx.cs" Inherits="BookPet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>


    <link rel="stylesheet" href="components/bootstrap2/css/bootstrap.css"/>
 <link rel="stylesheet" href="components/bootstrap2/css/bootstrap-responsive.css"/>
 <link rel="stylesheet" href="css/calendar.css"/>
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
       <li class="active"><a href="Admin.aspx">Calendar</a></li>
        <li><a href="DateSettings.aspx">Date Settings</a></li>
        <li><a href="UserAccts.aspx">User Accounts</a></li>
        <li><a href="Reports.aspx">Reports</a></li>
        <li><a href="Account.aspx">My Account</a></li>
        <li><a href="Invoice.aspx">Invoice</a></li>
        <li><a href="BookPet.aspx">Book an Appointment</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
      </ul>
    </div>
  </div>
</nav>
       <!-- /TOP MEMBER NAVBAR-->


        <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3 aria-setsize="12">Book Now&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Booking #:<asp:TextBox ID="TXTBXBOOKINGNO" runat="server" ReadOnly="True" Width="91px"></asp:TextBox>
                    </h3></td>
                <td class="auto-style7">Date</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TXTBXDATE" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style5">Customer ID</td>
                <td class="auto-style6" style="width: 80px">
                    <asp:TextBox ID="TXTBXCUSTOMERID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">Customer Name</td>
                <td class="auto-style16">
                    <asp:TextBox ID="TXTBXCUSTOMERNAME" runat="server"></asp:TextBox></td>
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
                    <asp:DropDownList ID="DRPBRANCH" runat="server">
                        <asp:ListItem>Select Branch</asp:ListItem>
                        <asp:ListItem>Duniden</asp:ListItem>
                        <asp:ListItem>Glen Ines</asp:ListItem>
                        <asp:ListItem>Glenfield</asp:ListItem>
                        <asp:ListItem>Grey Lynn</asp:ListItem>
                        <asp:ListItem>Papanui</asp:ListItem>
                        <asp:ListItem>St. Lukes</asp:ListItem>
                        <asp:ListItem>Sylvia Park</asp:ListItem>
                        <asp:ListItem>Takanini</asp:ListItem>
                        <asp:ListItem>Te Rapa</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">Groomer</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DRPGROOMER" runat="server">
                        <asp:ListItem>Select Groomer</asp:ListItem>
                        <asp:ListItem>Groomer 1</asp:ListItem>
                        <asp:ListItem>Groomer 2</asp:ListItem>
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td style="height:40px" class="auto-style9">&nbsp;</td>
                <td class="auto-style5"></td>
                <td class="auto-style10" colspan="3">
                    <asp:Button ID="BTNBOOK" runat="server" Text="Book an Appointment" Width="154px" OnClick="BTNBOOK_Click" />
                    &nbsp;<asp:Button ID="BTNCANCEL" runat="server" Text="Cancel" Width="113px" />
                &nbsp;&nbsp;</td>
            </tr>
        <%--</table>--%>


    </div>
    

    
    <div class="container">
	

	<div class="page-header">

		<div class="pull-right form-inline">
			<div class="btn-group">
				<button class="btn btn-primary" data-calendar-nav="prev"><< Prev</button>
				<button class="btn" data-calendar-nav="today">Today</button>
				<button class="btn btn-primary" data-calendar-nav="next">Next >></button>
			</div>
			<div class="btn-group">
				<button class="btn btn-warning" data-calendar-view="year">Year</button>
				<button class="btn btn-warning active" data-calendar-view="month">Month</button>
				<button class="btn btn-warning" data-calendar-view="week">Week</button>
				<button class="btn btn-warning" data-calendar-view="day">Day</button>
			</div>
		</div>

		<h3></h3>
		<small>To see example with events navigate to march 2013</small>
	</div>

	<div class="row">
		<div class="span9">
			<div id="calendar"></div>
		</div>
		<div class="span3">
			

			<h4>Events</h4>
			<small>This list is populated with events dynamically</small>
			<ul id="eventlist" class="nav nav-list"></ul>
		</div>
	</div>

	<div class="clearfix"></div>


	<div class="modal hide fade" id="events-modal">
		<div class="modal-header">
			<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
			<h3>Event</h3>
		</div>
		<div class="modal-body" style="height: 400px">
		</div>
		<div class="modal-footer">
			<a href="#" data-dismiss="modal" class="btn">Close</a>
		</div>
	</div>

	<script type="text/javascript" src="components/jquery/jquery.min.js"></script>
	<script type="text/javascript" src="components/underscore/underscore-min.js"></script>
	<script type="text/javascript" src="components/bootstrap2/js/bootstrap.min.js"></script>
	<script type="text/javascript" src="components/jstimezonedetect/jstz.min.js"></script>
	<script type="text/javascript" src="js/language/bg-BG.js"></script>
	<script type="text/javascript" src="js/language/nl-NL.js"></script>
	<script type="text/javascript" src="js/language/fr-FR.js"></script>
	<script type="text/javascript" src="js/language/de-DE.js"></script>
	<script type="text/javascript" src="js/language/el-GR.js"></script>
	<script type="text/javascript" src="js/language/it-IT.js"></script>
	<script type="text/javascript" src="js/language/hu-HU.js"></script>
	<script type="text/javascript" src="js/language/pl-PL.js"></script>
	<script type="text/javascript" src="js/language/pt-BR.js"></script>
	<script type="text/javascript" src="js/language/ro-RO.js"></script>
	<script type="text/javascript" src="js/language/es-CO.js"></script>
	<script type="text/javascript" src="js/language/es-MX.js"></script>
	<script type="text/javascript" src="js/language/es-ES.js"></script>
	<script type="text/javascript" src="js/language/ru-RU.js"></script>
	<script type="text/javascript" src="js/language/sk-SR.js"></script>
	<script type="text/javascript" src="js/language/sv-SE.js"></script>
	<script type="text/javascript" src="js/language/zh-CN.js"></script>
	<script type="text/javascript" src="js/language/cs-CZ.js"></script>
	<script type="text/javascript" src="js/language/ko-KR.js"></script>
	<script type="text/javascript" src="js/language/zh-TW.js"></script>
	<script type="text/javascript" src="js/language/id-ID.js"></script>
	<script type="text/javascript" src="js/language/th-TH.js"></script>
	<script type="text/javascript" src="js/calendar.js"></script>
	<script type="text/javascript" src="js/app.js"></script>

	<script type="text/javascript">
		var disqus_shortname = 'bootstrapcalendar'; // required: replace example with your forum shortname
		(function() {
			var dsq = document.createElement('script'); dsq.type = 'text/javascript'; dsq.async = true;
			dsq.src = '//' + disqus_shortname + '.disqus.com/embed.js';
			(document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(dsq);
		})();
	</script>
</div>

</asp:Content>

