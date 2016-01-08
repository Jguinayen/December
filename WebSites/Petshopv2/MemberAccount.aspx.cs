using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MemberAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNREGISTER_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into CustomerDetails(Lastname,Firstname, Mobile, Email, MembershipDate, Username, Password, Address) values(@Lastname,@Firstname,@Mobile, @Email, @MembershipDate, @Username, @Password, @Address)", conn);

        cmd.Parameters.AddWithValue("@Lastname", TXTBXLNAME.Text);
        cmd.Parameters.AddWithValue("@Firstname", TXTBXFNAME.Text);
        cmd.Parameters.AddWithValue("@Mobile", TXTBXMOBILE.Text);
        cmd.Parameters.AddWithValue("@Email", TXTBXEMAIL.Text);
        cmd.Parameters.AddWithValue("@MembershipDate", TXTBXMEMDATE.Text);
        cmd.Parameters.AddWithValue("@Username", TXTBXUNAME.Text);
        cmd.Parameters.AddWithValue("@Password", TXTBXPWORD.Text);
        cmd.Parameters.AddWithValue("@Address", TXTBXADD.Text);



        conn.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            LBLMSG.Text = "SUCCESSFULLY REGISTERED!";
        }
        conn.Close();
    }
}