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
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            width: 17px;
            height: 26px;
        }
        .auto-style7 {
            width: 118px;
            height: 26px;
        }
        .auto-style8 {
            width: 101px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    <!-- Forms -->
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Label ID="LBLCUSTOMER" runat="server" Text="MILLIE"></asp:Label>
        &nbsp;
        &nbsp;
        &nbsp;
        <asp:Label ID="LBLBOOKNO" runat="server" Text="Label"></asp:Label>
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
                    <asp:Label ID="LBLPETID1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTHAIRTYPE1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXWEIGHT1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES1" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT1" runat="server" Height="16px">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            
        </table>
        <br />

        <!-- pet2-->
        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style31">PET 2</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet ID</td>
                <td class="auto-style6">
                    <asp:Label ID="LBL2" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style5">Breed</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TXTBXBREED2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style7">Pet Name</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style7">Hairtype</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTHAIRTYPE2" runat="server"> </asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXWEIGHT2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES2" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT2" runat="server">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            
        </table>
        <br />

        <!--pet3-->
        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"></td>
                
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
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Name</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTHAIRTYPE3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">Weight</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXWEIGHT3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES3" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT3" runat="server">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            
        </table>
        <br />
        <!--pet4-->
        
        <asp:Button ID="BTNBOOK" runat="server" Height="30px" Text="BOOK" Width="135px" OnClick="BTNBOOK_Click" />
        
        <br />

    <!-- /Forms -->
        <p></p>



    </div>
    </form>
</body>
</html>
