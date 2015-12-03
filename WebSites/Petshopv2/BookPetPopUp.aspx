<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPetPopUp.aspx.cs" Inherits="BookPetPopUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book My Pet</title>
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
        
    <!-- Forms -->
        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"><h3>PET DETAILS</h3></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style31">PET 1</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Pet ID</td>
                <td class="auto-style3">
                    001</td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    Labrador</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList27" runat="server">
                        <asp:ListItem>Charlie</asp:ListItem>
                        <asp:ListItem>Tuffy</asp:ListItem>
                        <asp:ListItem>Pollux</asp:ListItem>
                        <asp:ListItem>Hachiko</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Smooth Coat</asp:ListItem>
                        <asp:ListItem>Medium Coat</asp:ListItem>
                        <asp:ListItem>Long Coat</asp:ListItem>
                        <asp:ListItem>Wire or Broken Coat</asp:ListItem>
                        <asp:ListItem>Wavy Coat</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    Dog</td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList6" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Others</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox11" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
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
                <td class="auto-style31">PET 2</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">Pet ID</td>
                <td class="auto-style3">
                    002</td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    Labrador</td>
            </tr>
            <tr>
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList31" runat="server">
                        <asp:ListItem>Charlie</asp:ListItem>
                        <asp:ListItem>Tuffy</asp:ListItem>
                        <asp:ListItem>Pollux</asp:ListItem>
                        <asp:ListItem>Hachiko</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList32" runat="server">
                        <asp:ListItem>Smooth Coat</asp:ListItem>
                        <asp:ListItem>Medium Coat</asp:ListItem>
                        <asp:ListItem>Long Coat</asp:ListItem>
                        <asp:ListItem>Wire or Broken Coat</asp:ListItem>
                        <asp:ListItem>Wavy Coat</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    Dog</td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList33" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Others</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList34" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox26" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style31">PET 3</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Pet ID</td>
                <td class="auto-style3">
                    003</td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    Labrador</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList35" runat="server">
                        <asp:ListItem>Charlie</asp:ListItem>
                        <asp:ListItem>Tuffy</asp:ListItem>
                        <asp:ListItem>Pollux</asp:ListItem>
                        <asp:ListItem>Hachiko</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList36" runat="server">
                        <asp:ListItem>Smooth Coat</asp:ListItem>
                        <asp:ListItem>Medium Coat</asp:ListItem>
                        <asp:ListItem>Long Coat</asp:ListItem>
                        <asp:ListItem>Wire or Broken Coat</asp:ListItem>
                        <asp:ListItem>Wavy Coat</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    Dog</td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList37" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Others</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList38" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox28" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style31">PET 4</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">Pet ID</td>
                <td class="auto-style3">
                    004</td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    Labrador</td>
            </tr>
            <tr>
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList39" runat="server">
                        <asp:ListItem>Charlie</asp:ListItem>
                        <asp:ListItem>Tuffy</asp:ListItem>
                        <asp:ListItem>Pollux</asp:ListItem>
                        <asp:ListItem>Hachiko</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList40" runat="server">
                        <asp:ListItem>Smooth Coat</asp:ListItem>
                        <asp:ListItem>Medium Coat</asp:ListItem>
                        <asp:ListItem>Long Coat</asp:ListItem>
                        <asp:ListItem>Wire or Broken Coat</asp:ListItem>
                        <asp:ListItem>Wavy Coat</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    Dog</td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList41" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Others</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList42" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox30" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
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
                    <asp:Button ID="Button1" runat="server" Text="Book an Appointment" Width="154px" />
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" Width="113px" />
                &nbsp;&nbsp;</td>
            </tr>
        </table>
    <!-- /Forms -->
        <p></p>



    </div>
    </form>
</body>
</html>
