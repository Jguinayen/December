using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminAddBranch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string connstr =
           System.Web.Configuration.WebConfigurationManager.ConnectionStrings
           ["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNSAVEBRANCH_Click(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into Branch (BranchName) values (@BranchName)", conn);

            cmd.Parameters.AddWithValue("@BranchName", TXTBRANCH.Text);

<<<<<<< HEAD:WebSites/Petshopv2/Branch.aspx.cs
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
=======
        conn.Open();
        if (cmd.ExecuteNonQuery()==1)
        {
            LBLMESS.Text = " Branch Successfully Added!";
        }
        conn.Close();
>>>>>>> f5b2f58c65e2f1be7127c61681d6ce3f5ca04d64:WebSites/Petshopv2/AdminAddBranch.aspx.cs
    }
}