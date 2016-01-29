using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class GroomerAppointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTGROOMERID.Text = Session["AdminUserID"].ToString();
        //TXTGROOMERID.Enabled = false;
        TXTGROOMER.Text = Session["UserName"].ToString();
        //TXTGROOMER.Enabled = false;

        //string Price = "select Price from JobTypeTable where Jobtype='" + TXTJOBTYPE.Text + "',conn";

        
        string GROOMERBOOKING = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(GROOMERBOOKING);
        SqlDataAdapter da = new SqlDataAdapter("Select CustomerID,PetID,PetName,JobType,JobDate,PetType,Breed,Weight from BookingDetails where Groomer = '" + Session["Groomer"] + "'", con);

        DataSet ds1 = new DataSet();
        da.Fill(ds1);

        GRIDAPPOINTMENT.DataSource = ds1;
        GRIDAPPOINTMENT.DataBind();
    }
   private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNSAVE_Click(object sender, EventArgs e)
    {
        string Price = "select Price from JobTypeTable where Jobtype='" + TXTJOBTYPE.Text + "',conn";
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into InvoiceTransaction(CustomerID,TransacDate, PetID,PetName, JobType, JobDate, PetType, Breed, Weight, Price) values(@CustomerID, @TransacDate, @PetID, @PetName, @JobType, @JobDate, @PetType, @Breed, @Weight, @Price)", conn);

        cmd.Parameters.AddWithValue("@CustomerID", TXTCUSTID.Text);
        cmd.Parameters.AddWithValue("@TransacDate", TXTDATE.Text);
        cmd.Parameters.AddWithValue("@PetID", TXTPETID.Text);
        cmd.Parameters.AddWithValue("@PetName", TXTPETNAME.Text);
        cmd.Parameters.AddWithValue("@JobType", TXTJOBTYPE.Text);
        cmd.Parameters.AddWithValue("@JobDate", TXTJDATE.Text);
        cmd.Parameters.AddWithValue("@PetType", TXTPTYPE.Text);
        cmd.Parameters.AddWithValue("@Breed", TXTPETBREED.Text);
        cmd.Parameters.AddWithValue("@Weight", TXTWEIGHT.Text);
        cmd.Parameters.AddWithValue("@Price", Price);

        conn.Open();
        if(cmd.ExecuteNonQuery()==1)
        {
            LBLMESS.Text = "Ready for Invoicing!";
        }
        conn.Close();
    }
    protected void GRIDAPPOINTMENT_SelectedIndexChanged(object sender, EventArgs e)
    {
        int rowIndex = GRIDAPPOINTMENT.SelectedIndex;
        TXTCUSTID.Text = GRIDAPPOINTMENT.SelectedRow.Cells[1].Text;
        TXTPETID.Text = GRIDAPPOINTMENT.SelectedRow.Cells[2].Text;
        TXTPETNAME.Text = GRIDAPPOINTMENT.SelectedRow.Cells[3].Text;
        TXTJOBTYPE.Text = GRIDAPPOINTMENT.SelectedRow.Cells[4].Text;
        TXTJDATE.Text = GRIDAPPOINTMENT.SelectedRow.Cells[5].Text;
        TXTPTYPE.Text = GRIDAPPOINTMENT.SelectedRow.Cells[6].Text;
        TXTPETBREED.Text = GRIDAPPOINTMENT.SelectedRow.Cells[7].Text;
        TXTWEIGHT.Text = GRIDAPPOINTMENT.SelectedRow.Cells[8].Text;

    }
}
