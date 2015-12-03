<%@ Page Title="" Language="VB" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="false" CodeFile="UserAccounts.aspx.vb" Inherits="UserAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3>Add New User</h3></td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
           
        </table>
        <br />

    <table width="100%">
           
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Username</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="61px" Width="374px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Phone No.</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox3" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">E-mail address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">User Type</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Groomer</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Active</td>
                <td class="auto-style4"><asp:CheckBox ID="CheckBox1" runat="server" /></td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Button Width="150px"  ID="Button2" runat="server" Text="Create User" />
                    &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Cancel" Width="99px" />
 
                   <br /><br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    
                </td>
            </tr>
        </table>

</asp:Content>

