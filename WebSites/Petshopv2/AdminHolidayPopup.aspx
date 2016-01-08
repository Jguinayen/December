<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHolidayPopup.aspx.cs" Inherits="AdminHolidayPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">Notes</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="45px" TextMode="MultiLine" Width="246px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
