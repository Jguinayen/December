using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MemberRegisterPet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATEREG.Text = DateTime.Today.ToShortDateString();
        TXTBXDATEREG.Enabled = false;
        TXTBXSIZE.Enabled = false;
        TXTBXOTHERS.Enabled = false;

        TXTBXCID.Text = Session["CustomerID"].ToString();
        TXTBXCID.Enabled = false;
        DRPBREED.Enabled = false;
    }

    private void clear()
    {
        TXTBXPETNAME.Text = "";
        TXTBXCID.Text = "";
        DRPTYPE.SelectedItem.Text = "";
        TXTBXOTHERS.Text = "";
        DRPBREED.SelectedItem.Text = "";
        DRPHAIRTYPE.SelectedItem.Text = "";
        DRPWEIGHT.SelectedItem.Text = "";
        TXTBXSIZE.Text = "";
        TXTBXPRECAUTION.Text = "";
    }    

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
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
            clear();
        }
        conn.Close();
    }
    protected void BTNCANCEL_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberBookAppt.aspx");
    }
   
    
    protected void DRPWEIGHT_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (DRPWEIGHT.SelectedItem.Text == "25-40 kg")
        {
            TXTBXSIZE.Text = "small";
        }
        else if (DRPWEIGHT.SelectedItem.Text == "40-65 kg")
        {
            TXTBXSIZE.Text = "medium";
        }
        else if (DRPWEIGHT.SelectedItem.Text == "65-80 kg")
        {
            TXTBXSIZE.Text = "large";
        }
        else if (DRPWEIGHT.SelectedItem.Text == "80-95 kg")
        {
            TXTBXSIZE.Text = "big large";
        }
    }
    protected void DRPTYPE_SelectedIndexChanged(object sender, EventArgs e)
    {
        DRPBREED.Enabled = true;
        if (DRPTYPE.SelectedItem.Text=="Others")
        {
            TXTBXOTHERS.Enabled = true;
            LBLOTHERS.Text = "Please enter other pet type..";
        }
    }
   
}