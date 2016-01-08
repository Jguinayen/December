using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AdminMyAcct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblAdminMyAcctID.Visible = false;
        txtAdminMyAcctName.Text = Session["Name"].ToString();
        txtAdminMyAcctUserName.Text = Session["UserName"].ToString();
        txtAdminMyAcctAddress.Text = Session["Address"].ToString();
        txtAdminMyAcctPhone.Text = Session["Phone"].ToString();
        txtAdminMyAcctEmail.Text = Session["Email"].ToString();
    }

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    protected void btnAdminMyAcctUpdate_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from AdminUsers where Password='" + txtAdminMyAcctCurrentPassword.Text + "'", conn);

        SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        DataSet newDataSet = new DataSet();
        newAdapter.Fill(newDataSet);

        conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            string UPass = newDataSet.Tables[0].Rows[0]["Password"].ToString();

            if (UPass == txtAdminMyAcctCurrentPassword.Text & txtAdminMyAcctNewPassword.Text == txtAdminMyAcctConfirmPassword.Text)
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("update AdminUsers set Name=@Name, UserName=@UserName, Address=@Address, Phone=@Phone, Email=@Email, Password=@Password where AdminUserID=@AdminUserID", conn);

                cmd.Parameters.AddWithValue("@AdminUserID", lblAdminMyAcctID.Text);
                cmd.Parameters.AddWithValue("@Name", txtAdminMyAcctName.Text);
                cmd.Parameters.AddWithValue("@UserName", txtAdminMyAcctUserName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAdminMyAcctAddress.Text);
                cmd.Parameters.AddWithValue("@Phone", txtAdminMyAcctPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtAdminMyAcctEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtAdminMyAcctNewPassword.Text);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblAdminMyAcctMsg.Text = "Your Account has been updated";
                }
                conn.Close();
            }
            else
            {
                lblAdminMyAcctMsg.Text = "Error Password and/or Password Did not Match";
            }
        }
    }
    protected void btnAdminMyAcctCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
}