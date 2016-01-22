<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBookPetPopoup.aspx.cs" Inherits="AdminBookPetPopoup" %>

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
        <asp:PlaceHolder ID="PHOLDER1" runat="server">
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
                <td class="auto-style31">Customer ID / Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXCUSTIDNAME" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style7">Pet ID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETID" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Hairtype</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXHAIRTYPE" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Name</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETNAME" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE" runat="server"></asp:TextBox>
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
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE" runat="server">
                    </asp:DropDownList>
                    
                </td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Date</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXJOBDATE" runat="server" ReadOnly="True"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Job Time</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXJOBTIME" runat="server" ReadOnly="True"></asp:TextBox>
                    
                </td>
            </tr>
            
        </table>
         </asp:PlaceHolder>
        <br />

        <!-- pet2-->
         <asp:PlaceHolder ID="PHOLDER2" runat="server" Visible="False" ViewStateMode="Enabled">

       

        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">

             

                <td class="auto-style9" colspan="4"><h3>PET DETAILS</h3></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style10">PET 2</td>
                <td class="auto-style11">
                    </td>
                <td class="auto-style10"></td>
                <td class="auto-style10">
                    </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Customer ID / Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXCUSTIDNAME2" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style7">Pet ID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETID2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Hairtype</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXHAIRTYPE2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Name</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETNAME2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE2" runat="server"></asp:TextBox>
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
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES2" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE2" runat="server">
                    </asp:DropDownList>
                    
                </td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH2" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Date</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXJOBDATE2" runat="server" ReadOnly="True"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Job Time</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXJOBTIME2" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            
        </table>

       
         </asp:PlaceHolder>
        <br />

        <!--pet3-->
         <asp:PlaceHolder ID="PHOLDER3" runat="server" Visible="False">
        
        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">

             

                <td class="auto-style9" colspan="4"><h3>PET DETAILS</h3></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style10">PET 3</td>
                <td class="auto-style11">
                    </td>
                <td class="auto-style10"></td>
                <td class="auto-style10">
                    </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Customer ID / Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXCUSTIDNAME3" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style7">Pet ID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETID3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Hairtype</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXHAIRTYPE3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Name</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETNAME3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE3" runat="server"></asp:TextBox>
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
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES3" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE3" runat="server">
                    </asp:DropDownList>
                    
                </td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH3" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Date</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXJOBDATE3" runat="server" ReadOnly="True"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Job Time</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXJOBTIME3" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            
        </table>

         </asp:PlaceHolder>
        <br />

        <!--pet4-->
         <asp:PlaceHolder ID="PHOLDER4" runat="server" Visible="False">
        
        <table style="width: 800px;" border="0">
            <tr style="background-color:#ffd800;">

             

                <td class="auto-style9" colspan="4"><h3>PET DETAILS</h3></td>
                
            </tr>
            <tr style="background-color:#808080;">
                <td class="auto-style10">PET 4</td>
                <td class="auto-style11">
                    </td>
                <td class="auto-style10"></td>
                <td class="auto-style10">
                    </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style31">Customer ID / Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXCUSTIDNAME4" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style31">Breed</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TXTBXBREED4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style7">Pet ID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETID4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Hairtype</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXHAIRTYPE4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style5">Pet Name</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TXTBXPETNAME4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">Weight</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TXTBXWEIGHT4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Pet Type</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXPETTYPE4" runat="server"></asp:TextBox>
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
                <td class="auto-style1">Notes</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXNOTES4" runat="server" Height="50px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Groomer</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXGROOMER4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Type</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DRPJOBTYPE4" runat="server">
                    </asp:DropDownList>
                    
                </td>
                <td class="auto-style1">Branch</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXBRANCH4" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            
            <tr style="background-color:#ffe44c;">
                <td class="auto-style1">Job Date</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TXTBXJOBDATE4" runat="server" ReadOnly="True"></asp:TextBox>
                    
                </td>
                <td class="auto-style1">Job Time</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TXTBXJOBTIME4" runat="server" ReadOnly="True"></asp:TextBox>
                    
                </td>
            </tr>
            
        </table>

         </asp:PlaceHolder>
        <br />
        <br />

        <asp:Button ID="BTNBOOK" runat="server" Height="30px" Text="BOOK" Width="135px" OnClick="BTNBOOK_Click" />
        
        <br />

    <!-- /Forms -->
        <br />
        <asp:Label ID="LBLMESS" runat="server"></asp:Label>
        <br />
        <p></p>



    </div>
    </form>
</body>
</html>
