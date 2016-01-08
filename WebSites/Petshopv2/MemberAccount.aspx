<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="MemberAccount.aspx.cs" Inherits="MemberAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <p id="pagetitle">My Membership Account</p>
    

    <table style="width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
           
           
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

</asp:Content>

