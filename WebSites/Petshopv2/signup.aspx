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
        .auto-style1 {
            height: 49px;
        }
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            height: 49px;
            width: 130px;
        }
        .auto-style5 {
            height: 50px;
            width: 130px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br /><br /><br />
    <br /><br /><br />
     <!-- Sign Up -->

   
    <table id="signup" style="width:300px;">
        <tr>
            <td width:="200px"> <label class="col-xs-11">Username</label></td>
            <td class="auto-style3"><asp:TextBox ID="txtSignupUserName" runat="server" CssClass="form-control"></asp:TextBox></td>
        
        </tr>
        <tr>
            <td class="auto-style1"><label class="col-xs-11">Password</label></td>
            <td class="auto-style4"><asp:TextBox runat="server" ID="txtSignupPassword" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
        
        </tr>
        <tr>
            <td class="auto-style2"><label class="col-xs-11">Confirm Password</label></td>  
            <td class="auto-style5"><asp:TextBox ID="txtSignupConfirmPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
      
        </tr>
        <tr>
            <td class="auto-style2"><label class="col-xs-11">Email</label></td>  
            <td class="auto-style5"><asp:TextBox ID="txtSignupEmail" runat="server" CssClass="form-control" ></asp:TextBox> </td>
      
        </tr>

        <tr>
            <td class="auto-style5"><asp:DropDownList ID="cbSignupUserType" runat="server" Visible="False">
                <asp:ListItem>Member</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td></td>  
            <td class="auto-style3"><asp:Button ID="btSignup" runat="server" CssClass="btn btn-success" Text="Sign Up" OnClick="btSignup_Click" /></td>
      
        </tr>

    </table>            
 

        <!-- Sign Up -->
       <br /><br /><br />

</asp:Content>

