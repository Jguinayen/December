﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPetPopUp.aspx.cs" Inherits="BookPetPopUp" %>

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
        <asp:Label ID="LBLBOOKINGNO" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date :&nbsp;&nbsp;
        <asp:TextBox ID="TXTBXDATE" runat="server"></asp:TextBox>
&nbsp;
        <%--  PET 1--%><%--<asp:PlaceHolder ID="PHOLDER1" runat="server" Visible="False">--%>
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
                    <asp:DropDownList ID="DRPPETNAME" runat="server">
                    </asp:DropDownList>
<<<<<<< HEAD
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [PetId], [PetName] FROM [PetDetails] WHERE ([CustomerID] = @CustomerID)">
                        <SelectParameters>
                            <asp:SessionParameter Name="CustomerID" SessionField="CustomerID" Type="String" DefaultValue="CustomerID" />
                        </SelectParameters>
                    </asp:SqlDataSource>
=======
                    
>>>>>>> dfb51fbf71734cf4e1a4edfd19bf93b41a04f1f1
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETID" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style1">Hairtype</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTHAIRTYPE" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Type</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETTYPE" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style1">Coat Condition</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DRPCOAT" runat="server" Height="16px">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>Matted</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE" runat="server">
                    </asp:DropDownList>
                    
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <%-- </asp:PlaceHolder>--%>
        <br />

        <!-- pet2-->
        <%-- <asp:PlaceHolder ID="PHOLDER2" runat="server" Visible="False" ViewStateMode="Enabled">--%>
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
                    <asp:DropDownList ID="DRPPETNAME2" runat="server">
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
                    <asp:TextBox ID="TXTBXWEIGHT2" runat="server" ReadOnly="True" ></asp:TextBox>
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
                    </asp:DropDownList>
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER2" runat="server" ReadOnly="True"></asp:TextBox>
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
        <%-- </asp:PlaceHolder>--%>
        <br />

        <!--pet3-->
        <%-- <asp:PlaceHolder ID="PHOLDER3" runat="server" Visible="False">--%>
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
                    <asp:DropDownList ID="DRPPETNAME3" runat="server">
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
        <%-- </asp:PlaceHolder>--%>
        <br />

        <!--pet4-->
        <%-- <asp:PlaceHolder ID="PHOLDER4" runat="server" Visible="False">--%>
        <table style="width: 800px;" border="0">
               <tr style="background-color:#ffd800;">
                <td class="auto-style29" colspan="4"><h3>PET DETAILS</h3></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style31">PET 4</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Pet Name</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPPETNAME4" runat="server">
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
                    <asp:TextBox ID="TXTBXPETTYPE4" runat="server" ReadOnly="True" ></asp:TextBox>
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
                    <asp:TextBox ID="TXTBXBRANCH4" runat="server" ReadOnly="True" ></asp:TextBox>
                </td>
            </tr>
            
        </table>
        <%-- </asp:PlaceHolder>--%>
        <br />
        <br />

        <asp:Button ID="BTNBOOK" runat="server" Height="30px" Text="BOOK" Width="135px" OnClick="BTNBOOK_Click" />
        
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
