using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection Conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from Session where Email2='" + txtLoginEmail.Text + "'", Conn);

        SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        DataSet newDataSet = new DataSet();
        newAdapter.Fill(newDataSet);

        Conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            string UEmail = newDataSet.Tables[0].Rows[0]["Email2"].ToString();
            string UPass = newDataSet.Tables[0].Rows[0]["Password2"].ToString();
            string UType = newDataSet.Tables[0].Rows[0]["UserType2"].ToString();

            if (UEmail == txtLoginEmail.Text & UPass == txtLoginPassword.Text & UType == "Admin")
            {
                Conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select UserName2 from Session where Email2='" + txtLoginEmail.Text + "'", Conn);

                SqlDataAdapter newAdapter2 = new SqlDataAdapter(cmd);
                DataSet newDataSet2 = new DataSet();
                newAdapter2.Fill(newDataSet2);

                Conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string UserName = newDataSet2.Tables[0].Rows[0]["UserName2"].ToString();
                    Session["UserName"] = UserName;
                    Response.Redirect("Admin.aspx");
                }

                //SqlConnection con1 = new SqlConnection();
                //con1.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ToString();
                //string sql1 = " select * from Session where Email2 = @Email2 and Password2 = @Password2";
                //SqlCommand cmd1 = new SqlCommand(sql1, con1);
                //cmd1.Parameters.AddWithValue("Email2", txtLoginEmail.Text);
                //cmd1.Parameters.AddWithValue("Password2", txtLoginPassword.Text);

                //con1.Open();
                //SqlDataReader dr = cmd1.ExecuteReader();
                //if (dr.Read())
                //{
                //    con1.Close();
                //    string UserName = ;
                //    Session["UserName"] = UserName;
                //    Response.Redirect("Admin.aspx");
                //}
            }
            else if (UEmail == txtLoginEmail.Text & UPass == txtLoginPassword.Text & UType == "Groomer")
            {
                Conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select UserName2 from Session where Email2='" + txtLoginEmail.Text + "'", Conn);

                SqlDataAdapter newAdapter2 = new SqlDataAdapter(cmd);
                DataSet newDataSet2 = new DataSet();
                newAdapter2.Fill(newDataSet2);

                Conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string UserName = newDataSet2.Tables[0].Rows[0]["UserName2"].ToString();
                    Session["UserName"] = UserName;
                    Response.Redirect("GroomerReport.aspx");
                }
            }
            else if (UEmail == txtLoginEmail.Text & UPass == txtLoginPassword.Text & UType == "Member")
            {
                Conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select UserName2 from Session where Email2='" + txtLoginEmail.Text + "'", Conn);

                SqlDataAdapter newAdapter2 = new SqlDataAdapter(cmd);
                DataSet newDataSet2 = new DataSet();
                newAdapter2.Fill(newDataSet2);

                Conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string UserName = newDataSet2.Tables[0].Rows[0]["UserName2"].ToString();
                    Session["UserName"] = UserName;
                    Response.Redirect("booknow.aspx");
                }
            }
            else if (UEmail != txtLoginEmail.Text && UPass != txtLoginPassword.Text)
            {
                Response.Write("<script>alert('" + "Error! Account not yet match" + "')</script>");
            }
        }
        Conn.Close();
    }
}
