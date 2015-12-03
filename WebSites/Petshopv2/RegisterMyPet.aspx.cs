using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class RegisterMyPet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATEREG.Text = DateTime.Today.ToShortDateString();
        TXTBXDATEREG.Enabled = false;
        TXTBXSIZE.Enabled = false;
        TXTBXOTHERS.Enabled = false;

    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNSAVE_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into PetDetails(PetName, CustomerID, PetType, Other, Precaution, PetBreed, Hairtype, Weight, Size, RegistrationDate) values(@PetName, @CustomerID, @PetType, @Other, @Precaution, @PetBreed, @Hairtype, @Weight, @Size, @RegistrationDate)", conn);

        cmd.Parameters.AddWithValue("@PetName", TXTBXPETNAME.Text);
        cmd.Parameters.AddWithValue("@CustomerID", TXTBXCID.Text);
        cmd.Parameters.AddWithValue("@PetType", DRPTYPE.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Other", TXTBXOTHERS.Text);
        cmd.Parameters.AddWithValue("@PetBreed", DRPBREED.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Hairtype", DRPHAIRTYPE.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Weight", DRPWEIGHT.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Size", TXTBXSIZE.Text);
        cmd.Parameters.AddWithValue("@RegistrationDate", Convert.ToDateTime(DateTime.Today.ToShortDateString()));
        cmd.Parameters.AddWithValue("@Precaution", TXTBXPRECAUTION.Text);

        conn.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            LBLMSG.Text = "SUCCESSFULLY REGISTERED!";
        }
        conn.Close();

    }

}