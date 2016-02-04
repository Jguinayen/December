<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="KeepSessionAlive.aspx.cs" Inherits="KeepSessionAlive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
<meta id="MetaRefresh" http-equiv="refresh" content="21600;url=KeepSessionAlive.aspx" runat="server" />

<script language="javascript">
    window.status = "<%=WindowStatusText%>";
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

