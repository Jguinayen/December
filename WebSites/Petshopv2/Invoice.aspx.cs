using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Invoice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXCUSTNAME.Visible = false;
        TXTBXCUSTID.Visible = false;
        //TXTBXCUSTNAME.Text = Session["UserName"].ToString();
        //TXTBXCUSTID.Text = Session["CustomerID"].ToString();
        string USERDATE = DateTime.Now.ToShortDateString();//will be substituted by Session[Date] after all good and running
        TXTBXINVDATE.Text = USERDATE;
        // TXTBXCUSTID.Text = Session["CustomerID"].ToString();
        //TXTBXCUSTNAME.Text = Session["UserName"].ToString();
        //if (!this.IsPostBack)
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    string sql = null;
        //    string connetionString = "Data Source=.;Initial Catalog=pubs;User ID=sa;Password=*****";
        //    sql = "select stor_id,stor_name,state from stores";
        //    SqlConnection connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    SqlCommand command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(ds);
        //    adapter.Dispose();
        //    command.Dispose();
        //    connection.Close();
        //    //GridView1.DataSource = ds.Tables[0];
        //    //GridView1.DataBind();
        //}
    }

    //checkboxes........
    //Full Groom.....
    protected void CHKFULLGROOM_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKFULLGROOM.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Full Groom' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPFGROOM.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYFGROOM.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYFGROOM.Text) * Convert.ToDouble(TXTBXPFGROOM.Text);
            TXTBXTFGROOM.Text = Convert.ToString(TOTAL);

            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", TXTBXQTYFGROOM.Text);
            cmd.Parameters.AddWithValue("@Jobtype", "Full Groom");
            cmd.Parameters.AddWithValue("@Unitprice", TXTBXPFGROOM.Text);
            cmd.Parameters.AddWithValue("@TotalPrice", TXTBXTFGROOM.Text);
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            //GridView1.DataBind();
            conn.Close();

        }
        else if (CHKFULLGROOM.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);

            //cmd = new SqlCommand("Delete from InvoiceTemp where JobType='Full Groom' in (Select Status from InvoiceTemp='false') ", conn);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Full Groom' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", TXTBXQTYFGROOM.Text);
            cmd.Parameters.AddWithValue("@Jobtype", "Full Groom");
            cmd.Parameters.AddWithValue("@Unitprice", TXTBXPFGROOM.Text);
            cmd.Parameters.AddWithValue("@TotalPrice", TXTBXTFGROOM.Text);
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYFGROOM.Text = "";
            TXTBXPFGROOM.Text = "";
            TXTBXTFGROOM.Text = "";
            //GridView1.DataBind();
            conn.Close();
        }
    }
    //Platinum.....
    protected void CHKPLATINUM_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKPLATINUM.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Platinum' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPPLAT.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYPLAT.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYPLAT.Text) * Convert.ToDouble(TXTBXPPLAT.Text);
            TXTBXTPLAT.Text = Convert.ToString(TOTAL);

            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYPLAT.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Platinum");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPPLAT.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTPLAT.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKPLATINUM.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);

            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Platinum' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", TXTBXQTYPLAT.Text);
            cmd.Parameters.AddWithValue("@Jobtype", "Platinum");
            cmd.Parameters.AddWithValue("@Unitprice", TXTBXPPLAT.Text);
            cmd.Parameters.AddWithValue("@TotalPrice", TXTBXTPLAT.Text);
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();

            //clear textboxes
            TXTBXQTYPLAT.Text = "";
            TXTBXPPLAT.Text = "";
            TXTBXTPLAT.Text = "";

            conn.Close();
        }
    }
    //Gold
    protected void CHKGOLD_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKGOLD.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Gold Groom' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPGOLD.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYGOLD.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYGOLD.Text) * Convert.ToDouble(TXTBXPGOLD.Text);
            TXTBXTGOLD.Text = Convert.ToString(TOTAL);

            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYGOLD.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Gold");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPGOLD.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTGOLD.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKGOLD.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);

            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Gold' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", TXTBXQTYGOLD.Text);
            cmd.Parameters.AddWithValue("@Jobtype", "Gold");
            cmd.Parameters.AddWithValue("@Unitprice", TXTBXPGOLD.Text);
            cmd.Parameters.AddWithValue("@TotalPrice", TXTBXTGOLD.Text);
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();

            //clear textboxes
            TXTBXQTYGOLD.Text = "";
            TXTBXPGOLD.Text = "";
            TXTBXTGOLD.Text = "";

            conn.Close();

        }
    }
    protected void CHKMINI_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKMINI.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Mini Groom' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPMINI.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYMINI.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYMINI.Text) * Convert.ToDouble(TXTBXPMINI.Text);
            TXTBXTMINI.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYMINI.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Mini Groom");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPMINI.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTMINI.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKMINI.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Mini Groom' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYMINI.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Mini Groom");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPMINI.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTMINI.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYMINI.Text = "";
            TXTBXPMINI.Text = "";
            TXTBXTMINI.Text = "";
            conn.Close();
        }
    }
    protected void CHKSHAMPOO_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKSHAMPOO.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Shampoo' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPSHAMPOO.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYSHAMPOO.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYSHAMPOO.Text) * Convert.ToDouble(TXTBXPSHAMPOO.Text);
            TXTBXTSHAMPOO.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYSHAMPOO.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Shampoo");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPSHAMPOO.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTSHAMPOO.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKSHAMPOO.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Shampoo' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYSHAMPOO.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Shampoo");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPSHAMPOO.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTSHAMPOO.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYSHAMPOO.Text = "";
            TXTBXPSHAMPOO.Text = "";
            TXTBXTSHAMPOO.Text = "";
            conn.Close();
        }
    }
    protected void CHKWASHBLOW_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKWASHBLOW.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Washblow' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPWB.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYWB.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYWB.Text) * Convert.ToDouble(TXTBXPWB.Text);
            TXTBXTWB.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYWB.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Washblow");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPWB.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTWB.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        else if (CHKSHAMPOO.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Washblow' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYWB.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Shampoo");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPWB.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTWB.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYWB.Text = "";
            TXTBXPWB.Text = "";
            TXTBXTWB.Text = "";
            conn.Close();

        }
    }
    protected void CHKCALMING_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKCALMING.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Calming' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPCALMING.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYCALMING.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYCALMING.Text) * Convert.ToDouble(TXTBXPCALMING.Text);
            TXTBXTCALMING.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYCALMING.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Calming");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPCALMING.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTCALMING.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKCALMING.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Calming' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYCALMING.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Calming");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPCALMING.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTCALMING.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYCALMING.Text = "";
            TXTBXPCALMING.Text = "";
            TXTBXTCALMING.Text = "";
            conn.Close();

        }
    }
    protected void CHKCITRUS_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKCITRUS.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Citrus' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPCITRUS.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYCITRUS.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYCITRUS.Text) * Convert.ToDouble(TXTBXPCITRUS.Text);
            TXTBXTCITRUS.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYCITRUS.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Citrus");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPCITRUS.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTCITRUS.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKCITRUS.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Citrus' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYCITRUS.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Citrus");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPCITRUS.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTCITRUS.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYCITRUS.Text = "";
            TXTBXPCITRUS.Text = "";
            TXTBXTCITRUS.Text = "";
            conn.Close();

        }
    }

    protected void CHKSMOOTHIE_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKSMOOTHIE.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Smoothie' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPSMOOTHIE.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYSMOOTHIE.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYSMOOTHIE.Text) * Convert.ToDouble(TXTBXPSMOOTHIE.Text);
            TXTBXTSMOOTHIE.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYSMOOTHIE.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Smoothie");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPSMOOTHIE.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTSMOOTHIE.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKSMOOTHIE.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Smoothie' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYSMOOTHIE.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Smoothie");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPSMOOTHIE.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTSMOOTHIE.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYSMOOTHIE.Text = "";
            TXTBXPSMOOTHIE.Text = "";
            TXTBXTSMOOTHIE.Text = "";
            conn.Close();

        }
    }

    protected void CHKFLEARELIEF_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKFLEARELIEF.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'FleaRelief' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPFLEA.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYFLEA.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYFLEA.Text) * Convert.ToDouble(TXTBXPFLEA.Text);
            TXTBXTFLEA.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYFLEA.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "FleaRelief");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPFLEA.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTFLEA.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKFLEARELIEF.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='FleaRelief' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYFLEA.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "FleaRelief");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPFLEA.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTFLEA.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYFLEA.Text = "";
            TXTBXPFLEA.Text = "";
            TXTBXTFLEA.Text = "";
            conn.Close();
        }
    }
    protected void CHKKISSABLE_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKKISSABLE.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Kissable' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPKISS.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYKISS.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYKISS.Text) * Convert.ToDouble(TXTBXPKISS.Text);
            TXTBXTKISS.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYKISS.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Kissable");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPKISS.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTKISS.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKKISSABLE.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Kissable' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYKISS.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Kissable");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPKISS.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTKISS.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYKISS.Text = "";
            TXTBXPKISS.Text = "";
            TXTBXTKISS.Text = "";
            conn.Close();
        }
    }
    protected void CHKDYE_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKDYE.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Dye' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPDYE.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYDYE.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYDYE.Text) * Convert.ToDouble(TXTBXPDYE.Text);
            TXTBXTDYE.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYDYE.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Dye");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPDYE.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTDYE.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKDYE.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Dye' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYDYE.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Dye");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPDYE.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTDYE.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYDYE.Text = "";
            TXTBXPDYE.Text = "";
            TXTBXTDYE.Text = "";
            conn.Close();
        }
    }
    protected void CHKCUT_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKCUT.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Dye' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPCUT.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYCUT.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYCUT.Text) * Convert.ToDouble(TXTBXPCUT.Text);
            TXTBXTCUT.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYCUT.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Cut");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPCUT.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTCUT.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKCUT.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Cut' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYCUT.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Cut");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPCUT.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTCUT.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYCUT.Text = "";
            TXTBXPCUT.Text = "";
            TXTBXTCUT.Text = "";
            conn.Close();
        }
    }
    protected void CHKNAILTRIM_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKNAILTRIM.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'NailTrim' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPNAILTRIM.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYNAILTRIM.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYNAILTRIM.Text) * Convert.ToDouble(TXTBXPNAILTRIM.Text);
            TXTBXTNAILTRIM.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYNAILTRIM.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "NailTrim");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPNAILTRIM.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTNAILTRIM.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKNAILTRIM.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='NailTrim' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYNAILTRIM.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "NailTrim");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPNAILTRIM.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTNAILTRIM.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYNAILTRIM.Text = "";
            TXTBXPNAILTRIM.Text = "";
            TXTBXTNAILTRIM.Text = "";
            conn.Close();
        }
    }
    protected void CHKPEDICURE_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKPEDICURE.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Pedicure' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPPEDICURE.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYPEDICURE.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYPEDICURE.Text) * Convert.ToDouble(TXTBXPPEDICURE.Text);
            TXTBXTPEDICURE.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYPEDICURE.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Pedicure");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPPEDICURE.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTPEDICURE.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKPEDICURE.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Pedicure' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYPEDICURE.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "NailTrim");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPPEDICURE.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTPEDICURE.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYPEDICURE.Text = "";
            TXTBXPPEDICURE.Text = "";
            TXTBXTPEDICURE.Text = "";
            conn.Close();
        }
    }
    protected void CHKFACIAL_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKFACIAL.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Facial' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPFACIAL.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYFACIAL.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYFACIAL.Text) * Convert.ToDouble(TXTBXPFACIAL.Text);
            TXTBXTFACIAL.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYFACIAL.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Facial");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPFACIAL.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTFACIAL.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKFACIAL.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Facial' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYFACIAL.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Facial");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPFACIAL.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTFACIAL.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYFACIAL.Text = "";
            TXTBXPFACIAL.Text = "";
            TXTBXTFACIAL.Text = "";
            conn.Close();
        }
    }
    protected void CHKSHEDDING_CheckedChanged(object sender, EventArgs e)
    {
        if (CHKSHEDDING.Checked == true)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select Price from JobTypeTable where JobType = 'Shedding' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TXTBXPSHEDDING.Text = reader["Price"].ToString();

                reader.Close();
                conn.Close();
            }
            TXTBXQTYSHEDDING.Text = "1";

            double TOTAL;
            TOTAL = Convert.ToDouble(TXTBXQTYSHEDDING.Text) * Convert.ToDouble(TXTBXPSHEDDING.Text);
            TXTBXTSHEDDING.Text = Convert.ToString(TOTAL);

            //save to InvoiceTemp
            cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYSHEDDING.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Shedding");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPSHEDDING.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTSHEDDING.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "true");

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (CHKSHEDDING.Checked == false)
        {
            //delete from InvoiceTemp
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(connStr);
            cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Shedding' ", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTID.Text);
            cmd.Parameters.AddWithValue("@Qty", Convert.ToDouble(TXTBXQTYSHEDDING.Text));
            cmd.Parameters.AddWithValue("@Jobtype", "Shedding");
            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(TXTBXPSHEDDING.Text));
            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(TXTBXTSHEDDING.Text));
            cmd.Parameters.AddWithValue("@InvDate", Convert.ToDateTime(TXTBXINVDATE.Text));
            cmd.Parameters.AddWithValue("@Status", "false");

            conn.Open();
            cmd.ExecuteNonQuery();
            //clear textboxes
            TXTBXQTYSHEDDING.Text = "";
            TXTBXPSHEDDING.Text = "";
            TXTBXTSHEDDING.Text = "";
            conn.Close();
        }
    }

    protected void BTNUPDATEINVOICE_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd;

        cmd = new SqlCommand("Delete  from InvoiceTemp where Status ='false' ", conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        GridView1.DataBind();
        conn.Close();
    }
    protected void BTNPRINTINVOICE_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('" + "Error! Please Attach Printer!" + "')</script>");
    }
}