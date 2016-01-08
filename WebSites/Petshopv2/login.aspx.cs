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
            string SessionId = newDataSet.Tables[0].Rows[0]["SessionId"].ToString();
            Session["SessionId"] = SessionId;
            string UEmail = newDataSet.Tables[0].Rows[0]["Email2"].ToString();
            string UPass = newDataSet.Tables[0].Rows[0]["Password2"].ToString();
            string UType = newDataSet.Tables[0].Rows[0]["UserType2"].ToString();

            if (UEmail == txtLoginEmail.Text & UPass == txtLoginPassword.Text & UType == "Admin")
            {
                Conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select * from AdminUsers where Email='" + txtLoginEmail.Text + "'", Conn);

                SqlDataAdapter newAdapter2 = new SqlDataAdapter(cmd);
                DataSet newDataSet2 = new DataSet();
                newAdapter2.Fill(newDataSet2);

                Conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string AdminUserID = newDataSet2.Tables[0].Rows[0]["AdminUserID"].ToString();
                    Session["AdminUserID"] = AdminUserID;
                    string Name = newDataSet2.Tables[0].Rows[0]["Name"].ToString();
                    Session["Name"] = Name;
                    string UserName = newDataSet2.Tables[0].Rows[0]["UserName"].ToString();
                    Session["UserName"] = UserName;
                    string Address = newDataSet2.Tables[0].Rows[0]["Address"].ToString();
                    Session["Address"] = Address;
                    string Phone = newDataSet2.Tables[0].Rows[0]["Phone"].ToString();
                    Session["Phone"] = Phone;
                    string Email = newDataSet2.Tables[0].Rows[0]["Email"].ToString();
                    Session["Email"] = Email;
                    string Password = newDataSet2.Tables[0].Rows[0]["Password"].ToString();
                    Session["Password"] = Password;
                    Response.Redirect("Admin.aspx");
                }
            }
            else if (UEmail == txtLoginEmail.Text & UPass == txtLoginPassword.Text & UType == "Groomer")
            {
                Conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select * from AdminUsers where Email='" + txtLoginEmail.Text + "'", Conn);

                SqlDataAdapter newAdapter2 = new SqlDataAdapter(cmd);
                DataSet newDataSet2 = new DataSet();
                newAdapter2.Fill(newDataSet2);

                Conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string AdminUserID = newDataSet2.Tables[0].Rows[0]["AdminUserID"].ToString();
                    Session["AdminUserID"] = AdminUserID;
                    string Name = newDataSet2.Tables[0].Rows[0]["Name"].ToString();
                    Session["Name"] = Name;
                    string UserName = newDataSet2.Tables[0].Rows[0]["UserName"].ToString();
                    Session["UserName"] = UserName;
                    string Address = newDataSet2.Tables[0].Rows[0]["Address"].ToString();
                    Session["Address"] = Address;
                    string Phone = newDataSet2.Tables[0].Rows[0]["Phone"].ToString();
                    Session["Phone"] = Phone;
                    string Email = newDataSet2.Tables[0].Rows[0]["Email"].ToString();
                    Session["Email"] = Email;
                    string Password = newDataSet2.Tables[0].Rows[0]["Password"].ToString();
                    Session["Password"] = Password;
                    Response.Redirect("GroomerReport.aspx");
                }
            }
            else if (UEmail == txtLoginEmail.Text & UPass == txtLoginPassword.Text & UType == "Member")
            {
                Conn = new SqlConnection(connstr);
                cmd = new SqlCommand("select * from CustomerDetails where Email='" + txtLoginEmail.Text + "'", Conn);

                SqlDataAdapter newAdapter2 = new SqlDataAdapter(cmd);
                DataSet newDataSet2 = new DataSet();
                newAdapter2.Fill(newDataSet2);

                Conn.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string CustomerID = newDataSet2.Tables[0].Rows[0]["CustomerID"].ToString();
                    Session["CustomerID"] = CustomerID;
                    string LastName = newDataSet2.Tables[0].Rows[0]["LastName"].ToString();
                    Session["LastName"] = LastName;
                    string FirstName = newDataSet2.Tables[0].Rows[0]["FirstName"].ToString();
                    Session["FirstName"] = FirstName;
                    string Mobile = newDataSet2.Tables[0].Rows[0]["Mobile"].ToString();
                    Session["Mobile"] = Mobile;
                    string Email = newDataSet2.Tables[0].Rows[0]["Email"].ToString();
                    Session["Email"] = Email;
                    string MembershipDate = newDataSet2.Tables[0].Rows[0]["MembershipDate"].ToString();
                    Session["MembershipDate"] = MembershipDate;
                    string UserName = newDataSet2.Tables[0].Rows[0]["UserName"].ToString();
                    Session["UserName"] = UserName;
                    string Password = newDataSet2.Tables[0].Rows[0]["Password"].ToString();
                    Session["Password"] = Password;
                    string Address = newDataSet2.Tables[0].Rows[0]["Address"].ToString();
                    Session["Address"] = Address;
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
