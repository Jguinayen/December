<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JobType.aspx.cs" Inherits="JobType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TXTBXJTYPE" runat="server"></asp:TextBox>
        <asp:Button ID="BTNJTYPE" runat="server" OnClick="BTNJTYPE_Click" Text="Add JobType" />
    
    </div>
    </form>
</body>
</html>
