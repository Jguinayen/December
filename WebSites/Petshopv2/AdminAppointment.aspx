<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminAppointment.aspx.cs" Inherits="AdminAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">
    <p id="pagetitle"> Appointment for Today</p>
<table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px; height: 24px;">Enter User ID:</td>
            <td class="auto-style6" style="height: 24px; width: 177px">
            <asp:TextBox ID="TXTGROOMERID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="height: 24px">
                Groomer Name:</td>
            <td class="auto-style6" style="height: 24px">
                <asp:TextBox ID="TXTGROOMER" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6" style="height: 24px">
                Date:</td>          
            <td class="auto-style6" style="height: 24px">
                <asp:TextBox ID="TXTDATE" runat="server"></asp:TextBox>
            </td>          
    </tr>
    
     </table>
    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px;">
                <asp:GridView ID="GRIDAPPOINTMENT" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GRIDAPPOINTMENT_SelectedIndexChanged" Width="256%" BorderColor="Black" BorderStyle="Solid" CellPadding="4" CellSpacing="4" Font-Bold="True">
                    <Columns>
                        <asp:BoundField HeaderText="CustomerID" DataField="CustomerID" HtmlEncode="False" />
                        <asp:BoundField HeaderText="PetID" DataField="PetID" />
                        <asp:BoundField HeaderText="PetName" DataField="PetName" />
                        <asp:BoundField HeaderText="JobType" DataField="JobType" />
                        <asp:BoundField HeaderText="JobDate" DataField="JobDate" />
                        <asp:BoundField HeaderText="PetType" DataField="PetType" />
                        <asp:BoundField HeaderText="Breed" DataField="Breed" />
                        <asp:BoundField HeaderText="Weight" DataField="Weight" />
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
                <asp:Label ID="LBLMESSAGE" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
    </tr>
    </table>
    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px;">Customer ID</td>
            <td class="auto-style6" style="width: 156px">
            <asp:TextBox ID="TXTCUSTID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 123px">
                Job Date:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTJDATE" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6" style="width: 90px">
                JobType:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTJOBTYPE" runat="server"></asp:TextBox>
            </td>
                
    </tr>
    <tr>
            <td style="width:117px; ">Pet ID</td>
            <td class="auto-style6" style="width: 156px; ">
            <asp:TextBox ID="TXTPETID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 123px; ">
                Pet Name:</td>
            <td >
                
                <asp:TextBox ID="TXTPETNAME" runat="server"></asp:TextBox>
                
            </td>
            <td style=" width: 90px;">
                Pet Breed:</td>
            <td >
                <asp:TextBox ID="TXTPETBREED" runat="server"></asp:TextBox>
            </td>
    </tr>
  
    
    <tr>
            <td style="width:117px;">Pet Weight</td>
            <td class="auto-style6" style="width: 156px">
                <asp:TextBox ID="TXTWEIGHT" runat="server" Width="139px"></asp:TextBox>
            </td>
            <td class="auto-style6" style="width: 123px">
                Pet Type:</td>
            <td>
                
                <asp:TextBox ID="TXTPTYPE" runat="server"></asp:TextBox>
                
            </td>
            <td style="width: 90px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
    </tr>
  
    
    </table>
    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:86px;">Precaution:</td>
            <td class="auto-style6" style="width: 295px">
            <asp:TextBox ID="TXTPRECAUTION" runat="server" Width="232px" Height="49px" TextMode="MultiLine"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 181px">
                <asp:Button ID="BTNSAVE" runat="server" OnClick="BTNSAVE_Click" Text="Served" Height="39px" Width="121px" />
            </td>
            <td class="auto-style6" style="width: 246px">
                <asp:Label ID="LBLMESS" runat="server"></asp:Label>
            </td>
            <td class="auto-style6" style="width: 246px">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
                
    </tr>
    <tr>
            <td class="auto-style6" style="width: 86px">
                &nbsp;</td>
            <td class="auto-style6" style="width: 295px">
                &nbsp;</td>
            <td class="auto-style6" style="width: 181px">
                &nbsp;</td>
                
            <td class="auto-style6">
                &nbsp;</td>
                
            <td class="auto-style6">
                &nbsp;</td>
                
    </tr>
    </table>
</asp:Content>

