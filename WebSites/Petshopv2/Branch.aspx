<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Branch.aspx.cs" Inherits="Branch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TXTBRANCH" runat="server"></asp:TextBox>
        <asp:Button ID="BTNSAVEBRANCH" runat="server" OnClick="BTNSAVEBRANCH_Click" Text="Save Branch" />
    
    </div>
    </form>
</body>
</html>
