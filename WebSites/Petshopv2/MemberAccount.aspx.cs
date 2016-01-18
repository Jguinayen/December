using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class MemberAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXCUSTOMID.Enabled = false;
        TXTBXCUSTOMID.Text = Session["CustomerID"].ToString();
        TXTBXMEMDATE.Enabled = false;
        TXTBXMEMDATE.Text = Session["MembershipDate"].ToString();
        TXTBXUNAME.Text = Session["UserName"].ToString();
        TXTBXEMAIL.Text = Session["Email"].ToString();
        TXTBXLNAME.Text = Session["LastName"].ToString();
        TXTBXFNAME.Text = Session["FirstName"].ToString();
        TXTBXMOBILE.Text = Session["Mobile"].ToString();
        TXTBXADD.Text = Session["Address"].ToString();
    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    private void Clear()
    {
        TXTBXCUSTOMID.Text = "";
        TXTBXLNAME.Text = "";
        TXTBXFNAME.Text = "";
        TXTBXMOBILE.Text = "";
        TXTBXEMAIL.Text = "";
        TXTBXMEMDATE.Text = "";
        TXTBXUNAME.Text = "";
        TXTBXPWORD.Text = "";
        TXTBXADD.Text = "";
    }
    protected void BTNREGISTER_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select Password from CustomerDetails where Password='" + Session["Password"] + "'", conn);

        SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        DataSet newDataSet = new DataSet();
        newAdapter.Fill(newDataSet);

        conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            string UPass = newDataSet.Tables[0].Rows[0]["Password"].ToString();

            if (UPass == TXTBXCPWORD.Text & TXTBXCFMPWORD.Text == TXTBXPWORD.Text)
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Update CustomerDetails set Lastname=@Lastname, Firstname=@Firstname, Mobile=@Mobile, Email=@Email, MembershipDate=@MembershipDate, Username=@Username, Password=@Password, Address=@Address where CustomerID=@CustomerID", conn);

                cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTOMID.Text);
                cmd.Parameters.AddWithValue("@Lastname", TXTBXLNAME.Text);
                cmd.Parameters.AddWithValue("@Firstname", TXTBXFNAME.Text);
                cmd.Parameters.AddWithValue("@Mobile", TXTBXMOBILE.Text);
                cmd.Parameters.AddWithValue("@Email", TXTBXEMAIL.Text);
                cmd.Parameters.AddWithValue("@MembershipDate", Convert.ToDateTime(TXTBXMEMDATE.Text));
                cmd.Parameters.AddWithValue("@Username", TXTBXUNAME.Text);
                cmd.Parameters.AddWithValue("@Password", TXTBXPWORD.Text);
                cmd.Parameters.AddWithValue("@Address", TXTBXADD.Text);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    LBLMSG.Text = "SUCCESSFULLY UPDATED!";
                    Clear();
                }
                conn.Close();
            }
            else
            {
                LBLMSG.Text = "Input Password not recognized or unidentical!";
            }
        }
    }
        
    protected void BTNCANCEL_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberBookAppt.aspx");
    }
}