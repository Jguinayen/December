using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminUserAccts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    protected void btnAdminUserAcctsCreate_Click(object sender, EventArgs e)
    {
        //try
        //{
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into AdminUsers (Name, UserName, Address, Phone, Email, UserType, Branch, Active, Password) values (@Name, @UserName, @Address, @Phone, @Email, @UserType,@Branch, @Active, @Password)", conn);

            cmd.Parameters.AddWithValue("@Name", txtAdminUserAcctsName.Text);
            cmd.Parameters.AddWithValue("@UserName", txtAdminUserAcctsUserName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAdminUserAcctsAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtAdminUserAcctsPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtAdminUserAcctsEmail.Text);
            cmd.Parameters.AddWithValue("@UserType", cbAdminUserAcctsUserType.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Branch", cbAdminUserAcctsBranch.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Active", ckAdminUserAcctsActive.Checked);
            cmd.Parameters.AddWithValue("@Password", txtAdminUserAcctsPassword.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into Session (UserName2, Password2, Email2, UserType2) values (@UserName2, @Password2, @Email2, @UserType2)", conn);
            cmd.Parameters.AddWithValue("@UserName2", txtAdminUserAcctsUserName.Text);
            cmd.Parameters.AddWithValue("@Password2", txtAdminUserAcctsPassword.Text);
            cmd.Parameters.AddWithValue("@Email2", txtAdminUserAcctsEmail.Text);
            cmd.Parameters.AddWithValue("@UserType2", cbAdminUserAcctsUserType.SelectedItem.Text);
            //cmd.ExecuteNonQuery();
            //cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BranchGroomer (BranchName, UserName) values (@BranchName, @UserName)", conn);
            cmd.Parameters.AddWithValue("@BranchName", cbAdminUserAcctsBranch.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@UserName", txtAdminUserAcctsUserName.Text);
        //}
        //catch (Exception ex)
        //{
            
            if (cmd.ExecuteNonQuery() == 1)
            {
                //Exception ex2 = ex;
                lblAdminUserAcctsMsg.Text = "User Succesffuly Created!";
                txtAdminUserAcctsName.Text = "";
                txtAdminUserAcctsUserName.Text = "";
                txtAdminUserAcctsAddress.Text = "";
                txtAdminUserAcctsPhone.Text = "";
                txtAdminUserAcctsEmail.Text = "";
                
            }

        //}
        conn.Close();
    }
    protected void btnAdminUserAcctsCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
}