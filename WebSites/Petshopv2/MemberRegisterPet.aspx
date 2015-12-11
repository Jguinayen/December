<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster-Member.master" AutoEventWireup="true" CodeFile="MemberRegisterPet.aspx.cs" Inherits="MemberRegisterPet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="leftcolumn" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="rightcolumn" Runat="Server">

    <p id="pagetitle">Register A Pet</p>
          
    <table style="width: 100%; border-spacing: 8px 8px; border-collapse:separate;">
            
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Customer ID</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXCID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">Date</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TXTBXDATEREG" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style15">Pet ID</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXPETID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">Breed</td>
                <td class="auto-style15">
                    <asp:DropDownList ID="DRPBREED" runat="server">
                        <asp:ListItem>-Please Select-</asp:ListItem>
                        <asp:ListItem>labrador</asp:ListItem>
                        <asp:ListItem>Afghan Hound</asp:ListItem>
                        <asp:ListItem>Affenpinscher</asp:ListItem>
                        <asp:ListItem>Akita</asp:ListItem>
                        <asp:ListItem>Australian Shepherd</asp:ListItem>
                        <asp:ListItem>Basset Hound</asp:ListItem>
                        <asp:ListItem>Beagle</asp:ListItem>
                        <asp:ListItem>Bichon Frise</asp:ListItem>
                        <asp:ListItem>Border Collie</asp:ListItem>
                        <asp:ListItem>Brittany</asp:ListItem>
                        <asp:ListItem>Boston Terrier</asp:ListItem>
                        <asp:ListItem>Boxer</asp:ListItem>
                        <asp:ListItem>Bulldog</asp:ListItem>
                        <asp:ListItem>Border Terrier</asp:ListItem>
                        <asp:ListItem>Brussels Griffon</asp:ListItem>
                        <asp:ListItem>Curly-Coated RETRIEVER</asp:ListItem>
                        <asp:ListItem>Cavalier King Charles Spaniel</asp:ListItem>
                        <asp:ListItem>Dalmatian</asp:ListItem>
                        <asp:ListItem>Dandie Dinmont Terrier</asp:ListItem>
                        <asp:ListItem>Great Dane</asp:ListItem>
                        <asp:ListItem>Greyhound</asp:ListItem>
                        <asp:ListItem>German Shepherd Dog</asp:ListItem>
                        <asp:ListItem>Golden RETRIEVER</asp:ListItem>
                        <asp:ListItem>Great Pyrenees</asp:ListItem>
                        <asp:ListItem>Komondor</asp:ListItem>
                        <asp:ListItem>Labrador Retriever</asp:ListItem>
                        <asp:ListItem>Lhasa Apso</asp:ListItem>
                        <asp:ListItem>Irish Terrier</asp:ListItem>
                        <asp:ListItem>Irish Water Spaniel</asp:ListItem>
                        <asp:ListItem>Maltese</asp:ListItem>
                        <asp:ListItem>Miniature Pinscher</asp:ListItem>
                        <asp:ListItem>Otterhound</asp:ListItem>
                        <asp:ListItem>Pembroke Welsh Corg</asp:ListItem>
                        <asp:ListItem>Pug</asp:ListItem>
                        <asp:ListItem>Poodle</asp:ListItem>
                        <asp:ListItem>Portuguese Water Dog</asp:ListItem>
                        <asp:ListItem>Rottweiler</asp:ListItem>
                        <asp:ListItem>Tibetan Terrier</asp:ListItem>
                        <asp:ListItem>Weimeraner</asp:ListItem>
                        <asp:ListItem>West Highland White Terrier</asp:ListItem>
                        <asp:ListItem>Yorkshire Terrier</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">Pet Name</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TXTBXPETNAME" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style10">Hairtype</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="DRPHAIRTYPE" runat="server">
                        <asp:ListItem>-Please Select-</asp:ListItem>
                        <asp:ListItem>Smooth Coat</asp:ListItem>
                        <asp:ListItem>Medium Coat</asp:ListItem>
                        <asp:ListItem>Long Coat</asp:ListItem>
                        <asp:ListItem>Wire or Broken Coat</asp:ListItem>
                        <asp:ListItem>Wavy Coat</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">Pet type</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DRPTYPE" runat="server" >
                        <asp:ListItem>Please Select</asp:ListItem>
                        <asp:ListItem>Dog</asp:ListItem>
                        <asp:ListItem>Cat</asp:ListItem>
                        <asp:ListItem>Rabbit</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">Weight</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPWEIGHT" runat="server">
                        <asp:ListItem>-Please Select-</asp:ListItem>
                        <asp:ListItem>25 to 40</asp:ListItem>
                        <asp:ListItem>65 to 80 lbs</asp:ListItem>
                        <asp:ListItem>75 to 95 lbs</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Others</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXOTHERS" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">Size</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXSIZE" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Notes</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TXTBXPRECAUTION" runat="server" Height="50px" TextMode="MultiLine" Width="280px"></asp:TextBox>
                </td>
                <td class="auto-style6">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT" runat="server">
                        <asp:ListItem>-Please Select-</asp:ListItem>
                        <asp:ListItem>matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3" colspan="3">
                    <%--<asp:Button ID="BTNSAVE" runat="server" OnClick="BTNSAVE_Click" Text="Add Pet" Width="154px" />
                    &nbsp;<asp:Button ID="BTNCANCEL" runat="server" Text="Cancel" Width="113px" />--%>

                    <asp:Button ID="Button1" runat="server" Text="Button" />
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

