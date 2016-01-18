<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminUserAccts.aspx.cs" Inherits="AdminUserAccts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

     <p id="pagetitle">Add New User</p>
    
    <table style="width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
           
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminUserAcctsName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtAdminUserAcctsName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Username</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminUserAcctsUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtAdminUserAcctsUserName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Password</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminUserAcctsPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminUserAcctsAddress" runat="server" TextMode="MultiLine" Height="61px" Width="374px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Phone No.</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtAdminUserAcctsPhone" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">E-mail Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAdminUserAcctsEmail" runat="server" Width="205px"  ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtAdminUserAcctsEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">User Type</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cbAdminUserAcctsUserType" runat="server">
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Groomer</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        <tr>
                <td class="auto-style3" style="height: 20px"></td>
                <td class="auto-style1" style="height: 20px">Branch</td>
                <td class="auto-style4" style="height: 20px">
                    <asp:DropDownList ID="cbAdminUserAcctsBranch" runat="server" DataSourceID="SqlDataSource1" DataTextField="BranchName" DataValueField="BranchName">
                        <asp:ListItem Value="Select Branch"></asp:ListItem>
                        <asp:ListItem Value="Glen Ines"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [BranchName] FROM [Branch]"></asp:SqlDataSource>
                </td>
                <td class="auto-style6" style="height: 20px"></td>
                <td class="auto-style2" style="height: 20px">
                    </td>
            </tr>
        <tr>
                <td class="auto-style3" style="height: 20px"></td>
                <td class="auto-style1" style="height: 20px">Active</td>
                <td class="auto-style4" style="height: 20px"><asp:CheckBox ID="ckAdminUserAcctsActive" runat="server" /></td>
                <td class="auto-style6" style="height: 20px"></td>
                <td class="auto-style2" style="height: 20px">
                    </td>
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
                    <asp:Button Width="150px"  ID="btnAdminUserAcctsCreate" runat="server" Text="Create User" OnClick="btnAdminUserAcctsCreate_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnAdminUserAcctsCancel" runat="server" Text="Cancel" Width="99px" OnClick="btnAdminUserAcctsCancel_Click" />
 
                   <br /><br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="lblAdminUserAcctsMsg" runat="server" Text=""></asp:Label>
                    
                </td>
            </tr>
        </table>

</asp:Content>

