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
using System.IO;
using System.Text;

public partial class GroomerInvoice : System.Web.UI.Page
{
    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;
    protected void Page_Load(object sender, EventArgs e)
    {
        string USERDATE = DateTime.Now.ToShortDateString();//will be substituted by Session[Date] after all good and running
        TXTBXINVDATE.Text = USERDATE;
    }

    //----------------------------------------checkboxes---------------------------------------------
    //Full Groom.....
    protected void CHKFULLGROOM_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEFGROOMCHARGE();
    }

    private void CALCULATEFGROOMCHARGE()
    {
        try
        {
            if (CHKFULLGROOM.Checked == true)
            {
                //query price for fullgroom
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
                    //conn.Close();
                }

                // for counting jobtype Full Groom...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as FGROOMQTY from InvoiceTransaction where JobType = 'Full Groom' and CustomerID = '" + LBLCUSTID.Text + "' ", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYFGROOM.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYFGROOM.Text) * Convert.ToDouble(TXTBXPFGROOM.Text);
                TXTBXTFGROOM.Text = Convert.ToString(TOTAL);

                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    //Platinum.....
    protected void CHKPLATINUM_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEPLATINUMCHARGE();
    }

    private void CALCULATEPLATINUMCHARGE()
    {
        try
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
                    //conn.Close();
                }
                // for counting jobtype Platinum...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as PLATINUMQTY from InvoiceTransaction where JobType = 'Platinum'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYPLAT.Text = count.ToString();
                    conn.Close();
                }


                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYPLAT.Text) * Convert.ToDouble(TXTBXPPLAT.Text);
                TXTBXTPLAT.Text = Convert.ToString(TOTAL);

                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    //Gold
    protected void CHKGOLD_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEGOLDGROOMCHARGE();
    }

    private void CALCULATEGOLDGROOMCHARGE()
    {
        try
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
                    // conn.Close();
                }

                // for counting jobtype Gold Groom...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as GGROOMQTY from InvoiceTransaction where JobType = 'Gold Groom'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYGOLD.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYGOLD.Text) * Convert.ToDouble(TXTBXPGOLD.Text);
                TXTBXTGOLD.Text = Convert.ToString(TOTAL);

                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }
    protected void CHKMINI_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEMINIGROOMCHARGE();
    }

    private void CALCULATEMINIGROOMCHARGE()
    {
        try
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
                    //conn.Close();
                }
                // for counting jobtype Mini Groom...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as MINIGROOMQTY from InvoiceTransaction where JobType = 'Mini Groom'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYMINI.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYMINI.Text) * Convert.ToDouble(TXTBXPMINI.Text);
                TXTBXTMINI.Text = Convert.ToString(TOTAL);

                //save to InvoiceTemp
                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
        
    }
    protected void CHKSHAMPOO_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATESHAMPOOCHARGE();
    }

    private void CALCULATESHAMPOOCHARGE()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }
    protected void CHKWASHBLOW_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEWASHBLOWCHARGE();
    }

    private void CALCULATEWASHBLOWCHARGE()
    {
        try
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
                    //conn.Close();
                }
                // for counting jobtype Washblow...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as WBQTY from InvoiceTransaction where JobType = 'Washblow'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYWB.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYWB.Text) * Convert.ToDouble(TXTBXPWB.Text);
                TXTBXTWB.Text = Convert.ToString(TOTAL);

                //save to InvoiceTemp
                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
            else if (CHKWASHBLOW.Checked == false)
            {
                //delete from InvoiceTemp
                string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(connStr);
                cmd = new SqlCommand("Update InvoiceTemp set CustomerID=@CustomerID, Qty=@Qty, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, InvDate=@InvDate, Status=@Status where JobType='Washblow' ", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    protected void CHKCALMING_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATECALMINGCHARGE();
    }

    private void CALCULATECALMINGCHARGE()
    {
        try
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
                    //conn.Close();
                }
                // for counting jobtype Calming...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as CALMINGQTY from InvoiceTransaction where JobType = 'Calming'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYCALMING.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYCALMING.Text) * Convert.ToDouble(TXTBXPCALMING.Text);
                TXTBXTCALMING.Text = Convert.ToString(TOTAL);

                //save to InvoiceTemp
                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    protected void CHKCITRUS_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATECITRUSCHARGE();
    }

    private void CALCULATECITRUSCHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    protected void CHKSMOOTHIE_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATESMOOTHIECHARGE();
    }

    private void CALCULATESMOOTHIECHARGE()
    {
        try
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
                    //conn.Close();
                }
                // for counting jobtype Smoothie...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as SMOOTHIEQTY from InvoiceTransaction where JobType = 'Smoothie'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYSMOOTHIE.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYSMOOTHIE.Text) * Convert.ToDouble(TXTBXPSMOOTHIE.Text);
                TXTBXTSMOOTHIE.Text = Convert.ToString(TOTAL);

                //save to InvoiceTemp
                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    protected void CHKFLEARELIEF_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEFLEARELIEFCHARGE();
    }

    private void CALCULATEFLEARELIEFCHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    protected void CHKKISSABLE_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEKISSCHARGE();
    }

    private void CALCULATEKISSCHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    protected void CHKDYE_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEDYECHARGE();
    }

    private void CALCULATEDYECHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }
    protected void CHKCUT_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATECUTCHARGE();
    }

    private void CALCULATECUTCHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }
    protected void CHKNAILTRIM_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATENAILTRIMCHARGE();
    }

    private void CALCULATENAILTRIMCHARGE()
    {
        try
        {
            if (CHKNAILTRIM.Checked == true)
            {
                string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlCommand cmd;
                string str;

                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                str = "select Price from JobTypeTable where JobType = 'Nail Trim' ";
                cmd = new SqlCommand(str, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TXTBXPNAILTRIM.Text = reader["Price"].ToString();

                    reader.Close();
                    //conn.Close();
                }
                // for counting jobtype NailTrim...
                SqlCommand cmd2 = new SqlCommand("select Count(JobType) as NTRIMQTY from InvoiceTransaction where JobType = 'Nail Trim'", conn);
                object count = cmd2.ExecuteScalar();
                if (count != null)
                {
                    TXTBXQTYNAILTRIM.Text = count.ToString();
                    conn.Close();
                }

                double TOTAL;
                TOTAL = Convert.ToDouble(TXTBXQTYNAILTRIM.Text) * Convert.ToDouble(TXTBXPNAILTRIM.Text);
                TXTBXTNAILTRIM.Text = Convert.ToString(TOTAL);

                //save to InvoiceTemp
                cmd = new SqlCommand("Insert into InvoiceTemp(CustomerID, Qty, JobType, UnitPrice, TotalPrice, InvDate, Status) values(@CustomerID, @Qty, @JobType, @UnitPrice, @TotalPrice, @InvDate, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }
    protected void CHKPEDICURE_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEPEDICURECHARGE();
    }

    private void CALCULATEPEDICURECHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
    protected void CHKFACIAL_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATEFACIALCHARGE();
    }

    private void CALCULATEFACIALCHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
     }
    protected void CHKSHEDDING_CheckedChanged(object sender, EventArgs e)
    {
        CALCULATESHEDDINGCHARGE();
    }

    private void CALCULATESHEDDINGCHARGE()
    {
        try
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTID.Text);
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    protected void BTNUPDATEINVOICE_Click(object sender, EventArgs e)
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd;

            cmd = new SqlCommand("Delete  from InvoiceTemp where Qty ='0' and Status ='false' ", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            GRDINVOICE.DataBind();
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        

    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /*Tell the compiler that the control is rendered
         * explicitly by overriding the VerifyRenderingInServerForm event.*/
    }

    protected void BTNPRINTINVOICE_Click(object sender, EventArgs e)
    {
        try
        {
            string CompanyName = "PetShoppe";
            string CustomerID = LBLCUSTID.Text;
            string CustomerName = TXTBXCUSTOMERNAME.Text;

            GRDINVOICE.PagerSettings.Visible = false;
            GRDINVOICE.DataBind();
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GRDINVOICE.RenderControl(hw);
            string gridHTML = sw.ToString().Replace("\"", "'")
                .Replace(System.Environment.NewLine, "");
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload = new function(){");
            sb.Append("var printWin = window.open('', '', 'left=0");
            sb.Append(",top=0,width=1000,height=600,status=0');");
            sb.Append("printWin.document.write(\"");
            sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
            sb.Append("<tr><td align='center' style='background-color: #18B5F0' colspan = '2'><b>Invoice Sheet</b></td></tr>");
            sb.Append("<br />");
            sb.Append("<tr><td colspan = '2'><b>Company Name: </b>");
            sb.Append(CompanyName);
            sb.Append("</table>");
            sb.Append("<tr><td colspan = '2'><b>Customer ID: </b>");
            sb.Append(CustomerID);
            sb.Append("<br />");
            sb.Append("<tr><td colspan = '2'><b>Customer Name: </b>");
            sb.Append(CustomerName);
            sb.Append("</td></tr>");
            sb.Append("</table>");
            sb.Append("<br />");
            sb.Append("<tr>");
            sb.Append(gridHTML);
            sb.Append("\");");
            sb.Append("printWin.document.close();");
            sb.Append("printWin.focus();");
            sb.Append("printWin.print();");
            sb.Append("printWin.close();};");
            sb.Append("</script>");
            ClientScript.RegisterStartupScript(this.GetType(), "GridPrint", sb.ToString());
            GRDINVOICE.PagerSettings.Visible = true;
            GRDINVOICE.DataBind();

            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd;

            cmd = new SqlCommand("Delete from InvoiceTemp", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Write("<script>alert('" + "Error! Please Attach Printer!" + "')</script>");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }
    protected void TXTBXCUSTOMERNAME_TextChanged(object sender, EventArgs e)
    {
        try
        {
            //query customer id based on value entered in customer name textbox
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlCommand cmd;
            string str;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            str = "select CustomerID from CustomerDetails where UserName = '" + TXTBXCUSTOMERNAME.Text + "' ";
            cmd = new SqlCommand(str, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                //display queried customer id 
                LBLCUSTID.Text = reader["CustomerID"].ToString();
                reader.Close();

                //query records of the customer
                string str2;
                SqlCommand cmd2;
                str2 = "select * from InvoiceTransaction where CustomerID='" + LBLCUSTID.Text + "' ";
                cmd2 = new SqlCommand(str2, conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    QUERYFGROOM();
                    QUERYPLATINUM();
                    QUERYGOLD();
                    QUERYMINI();
                    QUERYSHAMPOO();
                    QUERYWASHBLOW();
                    QUERYCALMING();
                    QUERYCITRUS();
                    QUERYSMOOTHIE();
                    QUERYFLEARELIEF();
                    QUERYKISSABLE();
                    QUERYDYE();
                    QUERYCUT();
                    QUERYNAILTRIM();
                    QUERYPEDICURE();
                    QUERYFACIAL();
                    QUERYSHEDDING();
                }

                conn.Close();
            }
            else
            {
                LBLMESS.Visible = true;
                LBLMESS.Text = "Nothing to invoice for this customer!";
            }
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        

    }

    //---------------------methods for jobtype------------------------------------    

    private void QUERYFGROOM()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Full Groom' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKFULLGROOM.Checked = true;
                CALCULATEFGROOMCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYPLATINUM()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Platinum' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKPLATINUM.Checked = true;
                CALCULATEPLATINUMCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYGOLD()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Gold Groom' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKGOLD.Checked = true;
                CALCULATEGOLDGROOMCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYMINI()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Mini Groom' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKMINI.Checked = true;
                CALCULATEMINIGROOMCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    private void QUERYSHAMPOO()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Shampoo' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKSHAMPOO.Checked = true;
                CALCULATESHAMPOOCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYWASHBLOW()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Washblow' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKWASHBLOW.Checked = true;
                CALCULATEWASHBLOWCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYCALMING()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Calming' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKCALMING.Checked = true;
                CALCULATECALMINGCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYCITRUS()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Citrus' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKCITRUS.Checked = true;
                CALCULATECITRUSCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    private void QUERYSMOOTHIE()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Smoothie' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKSMOOTHIE.Checked = true;
                CALCULATESMOOTHIECHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    private void QUERYFLEARELIEF()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='FleaRelief' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKFLEARELIEF.Checked = true;
                CALCULATEFLEARELIEFCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    private void QUERYKISSABLE()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Kissable' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKKISSABLE.Checked = true;
                CALCULATEKISSCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYDYE()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Dye' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKDYE.Checked = true;
                CALCULATEDYECHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYCUT()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Cut' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKCUT.Checked = true;
                CALCULATECUTCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYNAILTRIM()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Nail Trim' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKNAILTRIM.Checked = true;
                CALCULATENAILTRIMCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

    private void QUERYPEDICURE()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Pedicure' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKPEDICURE.Checked = true;
                CALCULATEPEDICURECHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYFACIAL()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Facial' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKFACIAL.Checked = true;
                CALCULATEFACIALCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    private void QUERYSHEDDING()
    {
        try
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string strquery;
            SqlCommand cmd;
            conn.Open();
            strquery = "select JobType from InvoiceTransaction where Jobtype='Shedding' ";
            cmd = new SqlCommand(strquery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CHKSHEDDING.Checked = true;
                CALCULATESHEDDINGCHARGE();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
       
    }

}