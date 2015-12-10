<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminMyAcct.aspx.cs" Inherits="AdminMyAcct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

     <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3>Manage My Account</h3></td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
           
        </table>
        <br />

    <table width:="100%">
           
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Username</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctUserName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
       
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctAddress" runat="server" TextMode="MultiLine" Height="61px" Width="374px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Phone No.</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtAdminMyAcctPhone" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">E-mail address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctEmail" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
         <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Current Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctCurrentPassword" runat="server" TextMode="Password">password</asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">New Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctNewPassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Confirm Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctConfirmPassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
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
                    <asp:Button Width="150px"  ID="btnAdminMyAcctUpdate" runat="server" Text="Update" OnClick="btnAdminMyAcctUpdate_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnAdminMyAcctCancel" runat="server" Text="Cancel" Width="99px" />
 
                   <br /><br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="lblAdminMyAcctMsg" runat="server" Text=""></asp:Label>
                    
                </td>
            </tr>
        </table>

</asp:Content>

