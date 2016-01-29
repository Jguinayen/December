<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Groomer.master" AutoEventWireup="true" CodeFile="GroomerAppointment.aspx.cs" Inherits="GroomerAppointment" %>

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
                <asp:GridView ID="GRIDAPPOINTMENT" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GRIDAPPOINTMENT_SelectedIndexChanged">
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
            </td>
    </tr>
    </table>
    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px;">Customer IDustomer ID</td>
            <td class="auto-style6" style="width: 156px">
            <asp:TextBox ID="TXTCUSTID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 123px">
                Job Date:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTJDATE" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                JobType:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTJOBTYPE" runat="server"></asp:TextBox>
            </td>
                
    </tr>
    <tr>
            <td style="width:117px;">Pet ID</td>
            <td class="auto-style6" style="width: 156px">
            <asp:TextBox ID="TXTPETID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 123px">
                Pet Name:</td>
            <td class="auto-style6">
                
                <asp:TextBox ID="TXTPETNAME" runat="server"></asp:TextBox>
                
            </td>
            <td class="auto-style6">
                Pet Breed:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTPETBREED" runat="server"></asp:TextBox>
            </td>
    </tr>
  
    
    </table>
    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px;">Pet Weight</td>
            <td class="auto-style6" style="width: 156px">
                <asp:TextBox ID="TXTWEIGHT" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6" style="width: 246px">
                Pet Type:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTPTYPE" runat="server"></asp:TextBox>
            </td>
                
    </tr>
    <tr>
            <td style="width:117px;">Precaution:</td>
            <td class="auto-style6" style="width: 156px">
            <asp:TextBox ID="TXTPRECAUTION" runat="server" Width="232px" Height="49px" TextMode="MultiLine"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 246px">
                <asp:Button ID="BTNSAVE" runat="server" OnClick="BTNSAVE_Click" Text="Served" />
            </td>
            <td class="auto-style6">
                <asp:Label ID="LBLMESS" runat="server" Text="Label"></asp:Label>
            </td>
                
    </tr>
    <tr>
            <td class="auto-style6" style="width: 156px">
                &nbsp;</td>
            <td class="auto-style6" style="width: 246px">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
                
    </tr>
    </table>
    
</asp:Content>

