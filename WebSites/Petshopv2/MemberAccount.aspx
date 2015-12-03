<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="MemberAccount.aspx.cs" Inherits="MemberAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

     <table style="width: 100%; background-color: #e8dede; padding: 2px 2px 2px 2px;">
            <tr style="background-color: #e8dede;">
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7" colspan="2"><h3>My Membership Account</h3></td>
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
                    <asp:TextBox ID="TXTBXCID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="61px" Width="374px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Phone No.</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TXTBXPETNAME" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Others</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXOTHERS" runat="server"></asp:TextBox>
                </td>
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
                    <asp:Button Width="150px" ID="Button1" runat="server" Text="Update" />&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="LBLMSG" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

</asp:Content>

