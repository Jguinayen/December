using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class JobType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private string connstr =
          System.Web.Configuration.WebConfigurationManager.ConnectionStrings
          ["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNJTYPE_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into JobTypeTable (JobType) values (@JobType)", conn);

        cmd.Parameters.AddWithValue("@JobType", TXTBXJTYPE.Text);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}