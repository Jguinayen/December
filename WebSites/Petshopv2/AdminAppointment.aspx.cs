using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AdminAppointment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTGROOMERID.Text = Session["AdminUserID"].ToString();
        TXTGROOMER.Text = Session["UserName"].ToString();
        //TXTDATE.Text = DateTime.Today.ToString("dd/mm/yyyy");
        TXTDATE.Text = DateTime.Today.ToShortDateString();

        string GROOMERBOOKING = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(GROOMERBOOKING);
        cmd = new SqlCommand("Select CustomerID,PetID,PetName,JobType,JobDate,PetType,Breed,Weight from BookingDetails", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        SqlDataReader rdr;

        DataSet ds1 = new DataSet();

        da.Fill(ds1);
        con.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            GRIDAPPOINTMENT.DataSource = ds1;
            GRIDAPPOINTMENT.DataBind();
        }
        else
        {
            Response.Write("<script>alert('" + "No Appointments for Today!" + "')</script>");
        }

    }
    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNSAVE_Click(object sender, EventArgs e)
    {
        string JobPrice = "Select Price from JobTypeTable where Jobtype='" + TXTJOBTYPE.Text + "',conn";


        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into InvoiceTransaction(CustomerID,TransacDate, PetID,PetName, JobType, JobDate, PetType, Breed, Weight, Price) values(@CustomerID, @TransacDate, @PetID, @PetName, @JobType, @JobDate, @PetType, @Breed, @Weight, @Price)", conn);

        cmd.Parameters.AddWithValue("@CustomerID", TXTCUSTID.Text);
        cmd.Parameters.AddWithValue("@TransacDate", TXTDATE.Text);
        cmd.Parameters.AddWithValue("@PetID", TXTPETID.Text);
        cmd.Parameters.AddWithValue("@PetName", TXTPETNAME.Text);
        cmd.Parameters.AddWithValue("@JobType", TXTJOBTYPE.Text);
        cmd.Parameters.AddWithValue("@JobDate", Convert.ToDateTime(TXTJDATE.Text));
        cmd.Parameters.AddWithValue("@PetType", TXTPTYPE.Text);
        cmd.Parameters.AddWithValue("@Breed", TXTPETBREED.Text);
        cmd.Parameters.AddWithValue("@Weight", TXTWEIGHT.Text);
        cmd.Parameters.AddWithValue("@Price", JobPrice);

        conn.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            LBLMESS.Text = "Ready for Invoicing!";

            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn2 = new SqlConnection(connStr);
            SqlCommand cmd2;

            cmd2 = new SqlCommand("Delete  from BookingDetails where PetName ='" + TXTPETNAME.Text + "' and JobType='" + TXTJOBTYPE.Text + "' ", conn2);
            conn2.Open();
            cmd2.ExecuteNonQuery();
            GRIDAPPOINTMENT.DataBind();
            conn2.Close();

            //reload gridview
            string GROOMERBOOKING = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(GROOMERBOOKING);
            SqlDataAdapter da = new SqlDataAdapter("Select CustomerID,PetID,PetName,JobType,JobDate,PetType,Breed,Weight from BookingDetails", con);

            DataSet ds1 = new DataSet();
            da.Fill(ds1);

            GRIDAPPOINTMENT.DataSource = ds1;
            GRIDAPPOINTMENT.DataBind();

        }
        conn.Close();
    }
    protected void GRIDAPPOINTMENT_SelectedIndexChanged(object sender, EventArgs e)
    {
        int rowIndex = GRIDAPPOINTMENT.SelectedIndex;
        TXTCUSTID.Text = GRIDAPPOINTMENT.SelectedRow.Cells[0].Text;
        TXTPETID.Text = GRIDAPPOINTMENT.SelectedRow.Cells[1].Text;
        TXTPETNAME.Text = GRIDAPPOINTMENT.SelectedRow.Cells[2].Text;
        TXTJOBTYPE.Text = GRIDAPPOINTMENT.SelectedRow.Cells[3].Text;
        TXTJDATE.Text = GRIDAPPOINTMENT.SelectedRow.Cells[4].Text;
        TXTPTYPE.Text = GRIDAPPOINTMENT.SelectedRow.Cells[5].Text;
        TXTPETBREED.Text = GRIDAPPOINTMENT.SelectedRow.Cells[6].Text;
        TXTWEIGHT.Text = GRIDAPPOINTMENT.SelectedRow.Cells[7].Text;

    }
}