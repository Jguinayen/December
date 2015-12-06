<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">



    <table style="width: 100%; border: solid 1px #808080; background-color:aquamarine;">
            <tr><td>Left Column</td></tr>
            <tr><td>&nbsp;</td></tr>
     </table>
    <br />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <asp:PlaceHolder ID="Pet1" runat="server">
     <table style="width: 100%; border: solid 1px #808080; background-color:aquamarine;">
            <tr><td>Right Column</td></tr>
            <tr><td>&nbsp;</td></tr>
     </table> 

        <br />
    </asp:PlaceHolder>

    <asp:PlaceHolder ID="PlaceHolder2" runat="server">
     <table style="width: 100%; border: solid 1px #808080; background-color:aquamarine;">
            <tr><td>Other Contents</td></tr>
            <tr><td>&nbsp;</td></tr>
     </table>
    </asp:PlaceHolder>



</asp:Content>

