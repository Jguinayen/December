<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!-- Sign Up -->

        <div class="center-page">

            <label class="col-xs-11">Email</label>
            <div class="col-xs-11">
            <asp:TextBox ID="tbEmail" runat="server" CssClass="form-control" TextMode="Email" OnTextChanged="tbEmail_TextChanged" Width="300px"></asp:TextBox>
            </div>

             <label class="col-xs-11">Password</label>
            <div class="col-xs-11">
            
            <asp:TextBox runat="server" ID="tbPass" CssClass="form-control" Width="300px" />

            </div>

             
            

            <div class="col-xs-11 space-vert">
                &nbsp;<asp:Button ID="Button1" runat="server" CssClass="btn btn-success"  Text="Log In" />
                </div>
                
        </div>

        <!-- Sign Up -->



  <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
</asp:Content>

