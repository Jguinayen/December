using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Appointment : System.Web.UI.Page
{

   
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //TXTGROOMERID.Text = Session["AdminUserID"].ToString();
        //TXTGROOMERID.Enabled = false;
        //TXTGROOMER.Text = Session["UserName"].ToString();
        //TXTGROOMER.Enabled = false;

        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd;

        cmd = new SqlCommand("Select * from BookingDetails where Groomer='" +TXTGROOMER.Text+ "' ", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        GRIDVIEWAPPTTODAY.DataBind();
        conn.Close();
    }
    protected void GRIDVIEWAPPTTODAY_SelectedIndexChanged(object sender, EventArgs e)
    {
        int rowIndex = GRIDVIEWAPPTTODAY.SelectedIndex;
        TXTCUSTID.Text = GRIDVIEWAPPTTODAY.SelectedRow.Cells[0].Text;
        TXTPETID.Text = GRIDVIEWAPPTTODAY.SelectedRow.Cells[1].Text;
        TXTPETNAME.Text = GRIDVIEWAPPTTODAY.SelectedRow.Cells[2].Text;
        TXTPETBREED.Text = GRIDVIEWAPPTTODAY.SelectedRow.Cells[3].Text;
        //TXTPRECAUTION.Text = GRIDVIEWAPPTTODAY.SelectedRow.Cells[1].Text;
    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNSAVE_Click(object sender, EventArgs e)
    {
        
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into InvoiceTransaction(CustomerID,TransacDate, PetID, JobType, JobID, Price) values(@CustomerID, @TransacDate, @PetID, @JobType, @JobID, @Price)", conn);

        cmd.Parameters.AddWithValue("@CustomerID", TXTCUSTID.Text);
        cmd.Parameters.AddWithValue("@TransacDate", TXTDATE.Text);
        cmd.Parameters.AddWithValue("@PetID", TXTPETID.Text);
        cmd.Parameters.AddWithValue("@JobType", TXTJOBTYPE.Text);
        cmd.Parameters.AddWithValue("@JobID", "JOBid");
        cmd.Parameters.AddWithValue("@Price", "pRICE");
        conn.Open();
        if(cmd.ExecuteNonQuery()==1)
        {
            LBLMESS.Text = "Ready for Invoicing!";
        }
        conn.Close();
    }
}