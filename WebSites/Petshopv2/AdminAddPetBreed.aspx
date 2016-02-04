<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Admin.master" AutoEventWireup="true" CodeFile="AdminAddPetBreed.aspx.cs" Inherits="AdminAddPetBreed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">

    <div>
    
        <table style="background-color: #e8dede; width: 115%; border-spacing: 8px 8px; border-collapse:separate; margin-left: 0px;">

            <tr>
                <td style="width: 118px">Add New Pet Breed:</td>
                <td style="width: 200px">
    
        <asp:TextBox ID="TXTNEWPETBREED" runat="server" Width="195px"></asp:TextBox>
                </td>
                <td style="width: 107px">
        <asp:Button ID="BTNNEWPETBREED" runat="server" OnClick="BTNNEWPETBREED_Click" Text="Save Pet Breed" />
    
                </td>
                <td style="width: 172px">
                    <asp:Label ID="LBLMESS" runat="server"></asp:Label>
    
                </td>
            </tr>
            <tr>
                <td style="width: 118px">Pet Type:</td>
                <td style="width: 200px">
    
        <asp:TextBox ID="TXTPETTYPE" runat="server" Width="195px"></asp:TextBox>
                </td>
                <td style="width: 107px">&nbsp;</td>
                <td style="width: 172px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 118px">&nbsp;</td>
                <td style="width: 200px">
                    &nbsp;</td>
                <td style="width: 107px">&nbsp;</td>
                <td style="width: 172px">&nbsp;</td>
            </tr>
        </table>
    
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">
</asp:Content>

