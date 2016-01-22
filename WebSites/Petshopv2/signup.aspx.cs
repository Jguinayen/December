using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    protected void btSignup_Click(object sender, EventArgs e)
    {
        if (txtSignupUserName.Text == "" || txtSignupPassword.Text == "" || txtSignupEmail.Text == "" || txtSignupConfirmPassword.Text == "")
        {
            Response.Write("<script>alert('" + "Please Do not Leave Blank" + "')</script>");
        }
        else if (txtSignupPassword.Text != txtSignupConfirmPassword.Text)
        {
            Response.Write("<script>alert('" + "Password not identical" + "')</script>");
        }
        else
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into CustomerDetails (UserName, Password, Email, MembershipDate, UserType) values (@UserName, @Password, @Email, @MembershipDate, @UserType)", conn);
            
            cmd.Parameters.AddWithValue("@UserName", txtSignupUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtSignupPassword.Text);
            cmd.Parameters.AddWithValue("@Email", txtSignupEmail.Text);
            cmd.Parameters.AddWithValue("@MembershipDate", Convert.ToDateTime(DateTime.Today.ToShortDateString()));
            cmd.Parameters.AddWithValue("@UserType", cbSignupUserType.SelectedItem.Text);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into Session (UserName2, Password2, Email2, UserType2) values (@UserName2, @Password2, @Email2, @UserType2)", conn);
            cmd.Parameters.AddWithValue("@UserName2", txtSignupUserName.Text);
            cmd.Parameters.AddWithValue("@Password2", txtSignupPassword.Text);
            cmd.Parameters.AddWithValue("@Email2", txtSignupEmail.Text);
            cmd.Parameters.AddWithValue("@UserType2", cbSignupUserType.SelectedItem.Text);

            //conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Response.Write("<script>alert('" + "Redirecting to Login Page" + "')</script>");
                Response.Redirect("login.aspx");
            }

            conn.Close();
        }
    }
}