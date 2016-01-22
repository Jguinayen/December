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
                <td class="auto-style3" style="height: 24px">&nbsp;</td>
                <td class="auto-style5" style="height: 24px">Firstname</td>
                <td class="auto-style4" style="height: 24px">
                    <asp:TextBox ID="TXTBXFNAME" runat="server"></asp:TextBox></td>

                 <td class="auto-style6">Current Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXCPWORD" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TXTBXCPWORD" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3" style="height: 24px"></td>
                <td class="auto-style5" style="height: 24px">Mobile</td>
                <td class="auto-style4" style="height: 24px">
                    
                    <asp:TextBox ID="TXTBXMOBILE" runat="server"></asp:TextBox></td>

                <td class="auto-style6" style="height: 24px">New Password</td>
                <td class="auto-style2" style="height: 24px">
                    <asp:TextBox ID="TXTBXPWORD" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TXTBXPWORD" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Email</td>
                <td class="auto-style4">
                    
                    <asp:TextBox ID="TXTBXEMAIL" runat="server"></asp:TextBox></td>
                <td class="auto-style6">Confirm Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXCFMPWORD" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TXTBXCFMPWORD" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>

                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">
                    
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
                    <asp:Button ID="BTNREGISTER" runat="server" Text="Update Profile" Width="154px" OnClick="BTNREGISTER_Click" />
                    &nbsp;<br />
                    <br />
                    <br />
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="LBLMSG" runat="server" Text=""></asp:Label>
                </td>
                
            </tr>
             </table>

</asp:Content>

