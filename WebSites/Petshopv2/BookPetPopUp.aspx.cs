using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class BookPetPopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        if (IsPostBack != null)
        {
            LBLCUSTOMERID.Text = Session["CustomerID"].ToString();
            //LBLBOOKINGNO.Text = Session["BookingNo"];
            LBLCUSTOMERNAME.Text = Session["CustomerName"].ToString();
            TXTBXGROOMER.Text = Session["Groomer"].ToString();
            TXTBXBRANCH.Text = Session["Branch"].ToString();
            //TXTBXGROOMER2.Text = Session["Groomer"].ToString();
            //TXTBXBRANCH2.Text = Session["Branch"].ToString();
            //TXTBXGROOMER3.Text = Session["Groomer"].ToString();
            //TXTBXBRANCH3.Text = Session["Branch"].ToString();
            //TXTBXGROOMER4.Text = Session["Groomer"].ToString();
            //TXTBXBRANCH4.Text = Session["Branch"].ToString();
        }

        //if (Session["Petnumber"] == "1")
        //{
        //    PHOLDER1.Visible = true;
        //}
        //else if (Session["Petnumber"] == "2")
        //{
        //    PHOLDER1.Visible = true;
        //    PHOLDER2.Visible = true;
        //}
        //else if (Session["Petnumber"] == "3")
        //{
        //    PHOLDER1.Visible = true;
        //    PHOLDER2.Visible = true;
        //    PHOLDER3.Visible = true;
        //}
        //else if (Session["Petnumber"] == "4")
        //{
        //    PHOLDER1.Visible = true;
        //    PHOLDER2.Visible = true;
        //    PHOLDER3.Visible = true;
        //    PHOLDER4.Visible = true;
        //}
    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    //method for saving a record in PetDetails Table
    private void InsertPetdetails()
    {
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, JobType, DateBooked, Groomer, Branch, Status) values(@CustomerID, @PetID, @JobType, @DateBooked, @Groomer, @Branch, @Status)", conn);

        cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTOMERID.Text);
        cmd.Parameters.AddWithValue("@PetID", DRPPETNAME.SelectedItem.Value);
        cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@JobDate", TXTBXDATE.Text);
        cmd.Parameters.AddWithValue("@DateBooked", TXTBXDATE.Text);
        cmd.Parameters.AddWithValue("@Groomer", Session["Groomer"] = TXTBXGROOMER.Text);
        cmd.Parameters.AddWithValue("@Branch", Session["Branch"] = TXTBXBRANCH.Text);
        cmd.Parameters.AddWithValue("@STATUS", "Upcoming");

        if (DRPJOBTYPE.SelectedItem.Text == "Full Groom")
        {
            cmd.Parameters.AddWithValue("@JobTypeCode", "1");
        }
        else if (DRPJOBTYPE.SelectedItem.Text == "Shampoo")
        {
            cmd.Parameters.AddWithValue("@JobTypeCode", "2");
        }
        else if (DRPJOBTYPE.SelectedItem.Text == "Dye")
        {
            cmd.Parameters.AddWithValue("@JobTypeCode", "3");
        }
        else if (DRPJOBTYPE.SelectedItem.Text == "Cut")
        {
            cmd.Parameters.AddWithValue("@JobTypeCode", "4");
        }
        else if (DRPJOBTYPE.SelectedItem.Text == "Nail Trim")
        {
            cmd.Parameters.AddWithValue("@JobTypeCode", "5");
        }

        conn.Open();

        if (cmd.ExecuteNonQuery() == 1)
        {
            LBLMESS.Text = "SUCCESSFULLY BOOKED! Please book another Pet";
        }

        conn.Close();
    }

    protected void BTNBOOK_Click(object sender, EventArgs e)
    {
        if (Session["Petnumber"] == "1")
        {
            InsertPetdetails();
            //    conn = new SqlConnection(connstr);
            //    cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, JobType, DateBooked, Groomer, Branch, Status) values(@CustomerID, @PetID, @JobType, @DateBooked, @Groomer, @Branch, @Status)", conn);

            //    cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTOMERID.Text);
            //    cmd.Parameters.AddWithValue("@PetID", DRPPETNAME.SelectedItem.Value);
            //    cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);
            //    cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
            //    cmd.Parameters.AddWithValue("@JobDate", TXTBXDATE.Text);
            //    cmd.Parameters.AddWithValue("@DateBooked", TXTBXDATE.Text);
            //    cmd.Parameters.AddWithValue("@Groomer", Session["Groomer"] = TXTBXGROOMER.Text);
            //    cmd.Parameters.AddWithValue("@Branch", Session["Branch"] = TXTBXBRANCH.Text);
            //    cmd.Parameters.AddWithValue("@STATUS", "Upcoming");

            //    if(DRPJOBTYPE.SelectedItem.Text == "Full Groom")
            //    {
            //        cmd.Parameters.AddWithValue("@JobTypeCode", "1");
            //    }
            //    else if (DRPJOBTYPE.SelectedItem.Text == "Shampoo")
            //    {
            //        cmd.Parameters.AddWithValue("@JobTypeCode", "2");
            //    }
            //    else if (DRPJOBTYPE.SelectedItem.Text == "Dye")
            //    {
            //        cmd.Parameters.AddWithValue("@JobTypeCode", "3");
            //    }
            //    else if (DRPJOBTYPE.SelectedItem.Text == "Cut")
            //    {
            //        cmd.Parameters.AddWithValue("@JobTypeCode", "4");
            //    }
            //    else if (DRPJOBTYPE.SelectedItem.Text == "Nail Trim")
            //    {
            //        cmd.Parameters.AddWithValue("@JobTypeCode", "5");
            //    }

            //conn.Open();

            //if (cmd.ExecuteNonQuery() == 1)
            //{
            //    LBLMESS.Text = "SUCCESSFULLY BOOKED! Please book another Pet";
            //}

            //conn.Close();
        }
        else if (Session["Petnumber"] != "1") ;
        {
            //declare Session["Petnumber"] as integer

        }
    }

    protected void DRPPETNAME_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(connstr))
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from PetDetails where PetName=@PetName ";

            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);

            conn.Open();

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                //return row data
                if (rdr.Read())
                {
                    //display returned value into textboxes
                    TXTBXPETID.Text = rdr.GetString(0);
                    TXTBXPETTYPE.Text = rdr.GetString(3);
                    TXTBXNOTES.Text = rdr.GetString(5);
                    TXTBXBREED.Text = rdr.GetString(6);
                    TXTHAIRTYPE.Text = rdr.GetString(7);
                    TXTHAIRTYPE.Text = rdr.GetString(8);
                }
            }
        }
    }
}