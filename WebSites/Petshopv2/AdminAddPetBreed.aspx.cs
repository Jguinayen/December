using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminAddPetBreed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string connstr =
           System.Web.Configuration.WebConfigurationManager.ConnectionStrings
           ["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    protected void BTNNEWPETBREED_Click(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into PetTypeBreed (PetType, PetBreed) values (@PetType, @PetBreed)", conn);

            cmd.Parameters.AddWithValue("@PetType", TXTPETTYPE.Text);
            cmd.Parameters.AddWithValue("@PetBreed", TXTNEWPETBREED.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                LBLMESS.Text = " New Breed Successfully Added!";
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
}