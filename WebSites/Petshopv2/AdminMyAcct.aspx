<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminMyAcct.aspx.cs" Inherits="AdminMyAcct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

     <p id="pagetitle">Manage My Account</p>
    
    <table style="width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
           
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdminMyAcctName" ErrorMessage="*"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdminMyAcctUserName" ErrorMessage="*"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAdminMyAcctAddress" ErrorMessage="*"></asp:RequiredFieldValidator>
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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAdminMyAcctPhone" EnableTheming="True" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">E-mail address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctEmail" runat="server" Width="205px" TextMode="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAdminMyAcctEmail" ErrorMessage="*"></asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="txtAdminMyAcctNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Confirm Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminMyAcctConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="lblAdminMyAcctID" runat="server" Text=""></asp:Label>
                    
                    <asp:Label ID="lblAdminMyAcctSessionID" runat="server" Text=""></asp:Label>
                    
                </td>
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
                    <asp:Button ID="btnAdminMyAcctCancel" runat="server" Text="Cancel" Width="99px" OnClick="btnAdminMyAcctCancel_Click" />
 
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

