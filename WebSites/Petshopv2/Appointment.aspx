<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Groomer.master" AutoEventWireup="true" CodeFile="Appointment.aspx.cs" Inherits="Appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <p id="pagetitle"> Appointment for Today</p>
<table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px;">Enter User ID:</td>
            <td class="auto-style6">
            <asp:TextBox ID="TXTGROOMERID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6">
                Groomer Name:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTGROOMER" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                &nbsp;</td>          
    </tr>
    </table>
    <table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
        <tr>
            <td style="width:117px;">
                <asp:GridView ID="GRIDVIEWAPPTTODAY" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GRIDVIEWAPPTTODAY_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                        <asp:BoundField DataField="PetID" HeaderText="PetID" SortExpression="PetID" />
                        <asp:BoundField DataField="PetName" HeaderText="PetName" SortExpression="PetName" />
                        <asp:BoundField DataField="JobType" HeaderText="JobType" SortExpression="JobType" />
                        <asp:BoundField DataField="JobDate" HeaderText="JobDate" SortExpression="JobDate" />
                        <asp:BoundField DataField="JobTime" HeaderText="JobTime" SortExpression="JobTime" />
                        <asp:BoundField DataField="PetType" HeaderText="PetType" SortExpression="PetType" />
                        <asp:BoundField DataField="Breed" HeaderText="Breed" SortExpression="Breed" />
                        <asp:BoundField DataField="Weight" HeaderText="Weight" SortExpression="Weight" />
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [CustomerID], [PetID], [PetName], [JobType], [JobDate], [JobTime], [PetType], [Breed], [Weight] FROM [BookingDetails] WHERE ([Groomer] = @Groomer)">
        <SelectParameters>
            <asp:ControlParameter ControlID="TXTGROOMER" Name="Groomer" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    </tr>
   </table>
<table style="background-color: #e8dede; width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
    <tr>
            <td style="width:117px;">Customer ID</td>
            <td class="auto-style6" style="width: 156px">
            <asp:TextBox ID="TXTCUSTID" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 123px">
                Date:</td>
            <td class="auto-style6">
                <asp:TextBox ID="TXTDATE" runat="server"></asp:TextBox>
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
            <td style="width:117px;">Precaution:</td>
            <td class="auto-style6" style="width: 156px">
            <asp:TextBox ID="TXTPRECAUTION" runat="server" Width="140px"></asp:TextBox> </td>
            <td class="auto-style6" style="width: 246px">
                <asp:Button ID="BTNSAVE" runat="server" OnClick="BTNSAVE_Click" Text="Served" />
            </td>
            <td class="auto-style6">
                <asp:Label ID="LBLMESS" runat="server" Text="Label"></asp:Label>
            </td>
                
    </tr>
    
            <td class="auto-style6" style="width: 156px">
                &nbsp;</td>
            <td class="auto-style6" style="width: 246px">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
                
    </tr>
    </table>
     </asp:Content>

