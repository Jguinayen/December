<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <!-- Sign Up -->

        <div class="login">

            <label class="col-xs-11">Email</label>
            <div class="col-xs-11">
            <asp:TextBox ID="txtLoginEmail" runat="server" CssClass="form-control" Width="250px"></asp:TextBox>
            </div>

             <label class="col-xs-11">Password</label>
            <div class="col-xs-11">
            
            <asp:TextBox runat="server" ID="txtLoginPassword" CssClass="form-control" Width="250px" />

            </div>

             <br /> <br />
            

            <div class="col-xs-11 space-vert">
                &nbsp;<asp:Button ID="btnLogin" runat="server" CssClass="btn btn-success" style="margin-top:10px;" Text="Log In" OnClick="btnLogin_Click" />
                </div>
                
        </div>

        <!-- Sign Up -->



  <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
</asp:Content>

