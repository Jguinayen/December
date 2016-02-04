<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminJobType.aspx.cs" Inherits="AdminJobType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
    <table style="background-color: #e8dede; width: 115%; border-spacing: 8px 8px; border-collapse:separate; margin-left: 0px;">
        <tr>
            <td style="width: 130px">&nbsp;&nbsp;&nbsp;&nbsp; Enter JobType:&nbsp;</td>
            <td style="width: 188px">
                <asp:TextBox ID="TXTBXJTYPE" runat="server"></asp:TextBox>
            </td>
            <td>
                
                <asp:Button ID="BTNJTYPE" runat="server" OnClick="BTNJTYPE_Click" Text="Add Job Type" />
                
            </td>
            <td>
                <asp:Label ID="LBLMESS" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 130px; height: 20px;"></td>
            <td style="width: 188px; height: 20px;"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 130px">&nbsp;</td>
            <td style="width: 188px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">
</asp:Content>

