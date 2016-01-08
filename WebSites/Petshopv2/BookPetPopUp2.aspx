<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPetPopUp2.aspx.cs" Inherits="BookPetPopUp2" %>

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
        .auto-style9 {
            height: 24px;
        }
        .auto-style10 {
            height: 23px;
        }
        .auto-style11 {
            width: 17px;
            height: 23px;
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
&nbsp;

    <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">

             

                <td class="auto-style9" colspan="4"><h3>PET DETAILS</h3></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style10">PET 1</td>
                <td class="auto-style11">
                    </td>
                <td class="auto-style10"></td>
                <td class="auto-style10">
                    </td>
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
                        <asp:ListItem>Dye</asp:ListItem>
                        <asp:ListItem>Cut</asp:ListItem>
                        <asp:ListItem>Nail Trim</asp:ListItem>
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
        <br />

        <asp:Button ID="BTNBOOK" runat="server" Height="30px" Text="BOOK" Width="135px"  />
        
        <br />

    <!-- /Forms -->
        <br />
        <br />
        <asp:Label ID="LBLMESS" runat="server" Text="Label"></asp:Label>
        <p></p>

    </div>
    </form>
</body>
</html>
