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
           // LBLCUSTOMERID.Text = Session["CustomerID"].ToString();
           // LBLBOOKINGNO.Text = Session["BookingNo"].ToString();
           // LBLCUSTOMERNAME.Text = Session["CustomerName"].ToString();
            TXTBXGROOMER1.Text = Session["Groomer"].ToString();
            TXTBXBRANCH1.Text = Session["Branch"].ToString();
            TXTBXGROOMER2.Text = Session["Groomer"].ToString();
            TXTBXBRANCH2.Text = Session["Branch"].ToString();
            TXTBXGROOMER3.Text = Session["Groomer"].ToString();
            TXTBXBRANCH3.Text = Session["Branch"].ToString();
            TXTBXGROOMER4.Text = Session["Groomer"].ToString();
            TXTBXBRANCH4.Text = Session["Branch"].ToString();
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

    
    protected void BTNBOOK_Click(object sender, EventArgs e)
    {
        //if (PHOLDER1.Visible == true)
        //{

        int PetNum =(int) Session["PetNumber"];
        for (int i = 1 ; i <= PetNum ; i++)
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, JobType, DateBooked, Groomer, Branch, Status) values(@CustomerID, @PetID, @JobType, @DateBooked, @Groomer, @Branch, @Status)", conn);

                cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTOMERID.Text);
                cmd.Parameters.AddWithValue("@PetID", DRPPETNAME1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@PetName", DRPPETNAME1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@JobDate", TXTBXDATE.Text);
                cmd.Parameters.AddWithValue("@DateBooked", TXTBXDATE.Text);
                cmd.Parameters.AddWithValue("@Groomer", Session["Groomer"] = TXTBXGROOMER1.Text);
                cmd.Parameters.AddWithValue("@Branch", Session["Branch"] = TXTBXBRANCH1.Text);
                cmd.Parameters.AddWithValue("@STATUS", "Upcoming");

                if(DRPJOBTYPE1.SelectedItem.Text == "Full Groom")
                {
                    cmd.Parameters.AddWithValue("@JobTypeCode", "1");
                }
                else if (DRPJOBTYPE1.SelectedItem.Text == "Shampoo")
                {
                    cmd.Parameters.AddWithValue("@JobTypeCode", "2");
                }
                else if (DRPJOBTYPE1.SelectedItem.Text == "Dye")
                {
                    cmd.Parameters.AddWithValue("@JobTypeCode", "3");
                }
                else if (DRPJOBTYPE1.SelectedItem.Text == "Cut")
                {
                    cmd.Parameters.AddWithValue("@JobTypeCode", "4");
                }
                else if (DRPJOBTYPE1.SelectedItem.Text == "Nail Trim")
                {
                    cmd.Parameters.AddWithValue("@JobTypeCode", "5");
                }

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                LBLMESS.Text = "SUCCESSFULLY BOOKED! Please book another Pet";
            }
            else
            {
                LBLMESS.Text = "ALL PETS SUCCESFULLY BOOKED, THANK YOU!";
            }

            conn.Close();
        }
    }
   
}