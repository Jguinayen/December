<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage-1.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        #signup { 
            color: #808080;
       }
        #signup, table { 
            margin: auto;
            width: 30%;
            padding: 4px 4px 4px 4px;
            vertical-align:central;
            
       }
        #signup, td { 
            height: 50px;
            vertical-align:bottom;
       }

        .center {
            margin: auto;
            width: 60%;
            padding: 10px;
            }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br /><br /><br />
    <br /><br /><br />
     <!-- Sign Up -->

   
    <table id="signup">
        <tr>
            <td width="200px"> <label class="col-xs-11">Username</label></td>
            <td><asp:TextBox ID="tbUname" runat="server" CssClass="form-control"></asp:TextBox></td>
        
        </tr>
        <tr>
            <td><label class="col-xs-11">Password</label></td>
            <td><%--<asp:TextBox ID="tbPass" runat="server" Class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>--%>
            <asp:TextBox runat="server" ID="tbPass" CssClass="form-control" /></td>
        
        </tr>
        <tr>
            <td><label class="col-xs-11">Confirm Password</label></td>  
            <td><asp:TextBox ID="tbCPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
      
        </tr>
        <tr>
            <td><label class="col-xs-11">Name</label></td>  
            <td>&nbsp;<asp:TextBox runat="server" ID="tbName" CssClass="form-control" /></td>
      
        </tr>
        <tr>
            <td><label class="col-xs-11">Email</label></td>  
            <td><asp:TextBox ID="tbEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox></td>
      
        </tr>
        <tr>
            <td></td>  
            <td><asp:Button ID="btSignup" runat="server" CssClass="btn btn-success" Text="Sign Up" OnClick="btSignup_Click" /></td>
      
        </tr>

    </table>            
 

        <!-- Sign Up -->
       <br /><br /><br />

</asp:Content>

