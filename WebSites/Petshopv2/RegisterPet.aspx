<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPet.aspx.cs" Inherits="RegisterPet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register My Pet</title>
    <style type="text/css">
        .auto-style1 {
            width: 118px;
        }
        .auto-style2 {
            width: 101px;
        }
        .auto-style3 {
            width: 17px;
        }
        .auto-style4 {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
    <!-- Forms -->
        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"><h3>PET REGISTRATION</h3></td>
                
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Pet ID</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:DropDownList ID="DropDownList22" runat="server">
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
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox22" runat="server" Width="223px"></asp:TextBox>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList23" runat="server">
                        <asp:ListItem>Smooth Coat</asp:ListItem>
<asp:ListItem>Medium Coat</asp:ListItem>
<asp:ListItem>Long Coat</asp:ListItem>
<asp:ListItem>Wire or Broken Coat</asp:ListItem>
<asp:ListItem>Wavy Coat</asp:ListItem>
                        
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList25" runat="server">
                        <asp:ListItem>Dog</asp:ListItem>
                        <asp:ListItem>Cat</asp:ListItem>
                        <asp:ListItem>Rabbit</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList24" runat="server">
                        <asp:ListItem>65 to 80 lbs</asp:ListItem>
                        <asp:ListItem>75 to 95 lbs</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Others</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList26" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox24" runat="server" Height="50px" TextMode="MultiLine" Width="280px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style4"></td>
                <td class="auto-style4" colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="Add Pet" Width="154px" />
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" Width="113px" />
                &nbsp;&nbsp;</td>
            </tr>
        </table>
    <!-- /Forms -->
        <p></p><p></p>

    </center>

    </div>
    </form>
</body>
</html>
