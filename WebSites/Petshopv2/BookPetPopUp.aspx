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
        Welcome &nbsp;
        &nbsp;
        <asp:Label ID="LBLCUSTOMERNAME" runat="server" Text="MILLIE"></asp:Label>
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp; CustomerID:&nbsp;
        <asp:Label ID="LBLCUSTOMERID" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Booking #:
        <asp:Label ID="LBLBOOKINGNO" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date :&nbsp;&nbsp;
        <asp:TextBox ID="TXTBXDATE" runat="server"></asp:TextBox>
&nbsp;<table style="width: 800px;" border="0">
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
                <td class="auto-style31">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPPETNAME1" runat="server" DataSourceID="SqlDataSource1" DataTextField="PetName" DataValueField="PetId">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [PetId], [PetName] FROM [PetDetails] WHERE ([CustomerID] = @CustomerID)">
                        <SelectParameters>
                            <asp:SessionParameter Name="CustomerID" SessionField="LBLCUSTOMERID" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETID1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTHAIRTYPE1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETTYPE1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT1" runat="server" ReadOnly="True"></asp:TextBox>
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
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE1" runat="server">
                        <asp:ListItem>Select Job Type</asp:ListItem>
                        <asp:ListItem>Full Groom</asp:ListItem>
                        <asp:ListItem>Shampoo</asp:ListItem>
                        <asp:ListItem>Nail Trim</asp:ListItem>
                        <asp:ListItem>Dye</asp:ListItem>
                        <asp:ListItem>Cut</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <br />

        <!-- pet2-->
        <table style="width: 800px;" border="0">
               <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"><h3>PET DETAILS</h3></td>
                
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
                <td class="auto-style31">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPPETNAME2" runat="server" DataSourceID="SqlDataSource1" DataTextField="PetName" DataValueField="PetId">
                    </asp:DropDownList>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETID2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXHAIRTYPE2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETTYPE2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT2" runat="server" ReadOnly="True" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES2" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT2" runat="server" Height="16px">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE2" runat="server">
                        <asp:ListItem>Select Job Type</asp:ListItem>
                        <asp:ListItem>Full Groom</asp:ListItem>
                        <asp:ListItem>Shampoo</asp:ListItem>
                        <asp:ListItem>Nail Trim</asp:ListItem>
                        <asp:ListItem>Dye</asp:ListItem>
                        <asp:ListItem>Cut</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTXBXGROOMER2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <br />

        <!--pet3-->
        <table style="width: 800px;" border="0">
               <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"><h3>PET DETAILS</h3></td>
                
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
                <td class="auto-style31">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPPETNAME3" runat="server" DataSourceID="SqlDataSource1" DataTextField="PetName" DataValueField="PetId">
                    </asp:DropDownList>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETID3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXHAIRTYPE3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETTYPE3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES3" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT3" runat="server" Height="16px">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE3" runat="server">
                        <asp:ListItem>Select Job Type</asp:ListItem>
                        <asp:ListItem>Full Groom</asp:ListItem>
                        <asp:ListItem>Shampoo</asp:ListItem>
                        <asp:ListItem>Nail Trim</asp:ListItem>
                        <asp:ListItem>Dye</asp:ListItem>
                        <asp:ListItem>Cut</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <br />
        <!--pet4-->
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
                <td class="auto-style31">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPPETNAME4" runat="server" DataSourceID="SqlDataSource1" DataTextField="PetName" DataValueField="PetId">
                    </asp:DropDownList>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETID4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXHAIRTYPE4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETTYPE4" runat="server" ReadOnly="True" OnTextChanged="TextBox20_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES4" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT4" runat="server" Height="16px">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE4" runat="server">
                        <asp:ListItem>Select Job Type</asp:ListItem>
                        <asp:ListItem>Full Groom</asp:ListItem>
                        <asp:ListItem>Shampoo</asp:ListItem>
                        <asp:ListItem>Nail Trim</asp:ListItem>
                        <asp:ListItem>Dye</asp:ListItem>
                        <asp:ListItem>Cut</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH4" runat="server" ReadOnly="True" OnTextChanged="TextBox24_TextChanged"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <br />
        <br />

        <asp:Button ID="BTNBOOK" runat="server" Height="30px" Text="BOOK" Width="135px" OnClick="BTNBOOK_Click" />
        
        <br />

    <!-- /Forms -->
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p></p>



    </div>
    </form>
</body>
</html>
