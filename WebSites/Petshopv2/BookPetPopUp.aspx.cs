﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class BookPetPopUp : System.Web.UI.Page
{
    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            TXTBXCUSTIDNAME.Text = Session["CustomerID"].ToString();
            TXTBXJOBDATE.Text = Session["DatePick"].ToString();
            TXTBXJOBTIME.Text = Session["TimePick"].ToString();
            TXTBXGROOMER.Text = Session["Groomer"].ToString();
            TXTBXBRANCH.Text = Session["Branch"].ToString();
            //** Pet 2
            TXTBXCUSTIDNAME2.Text = Session["CustomerID"].ToString();
            TXTBXJOBDATE2.Text = Session["DatePick"].ToString();
            TXTBXGROOMER2.Text = Session["Groomer"].ToString();
            TXTBXBRANCH2.Text = Session["Branch"].ToString();
            //** Pet 3
            TXTBXCUSTIDNAME3.Text = Session["CustomerID"].ToString();
            TXTBXJOBDATE3.Text = Session["DatePick"].ToString();
            TXTBXGROOMER3.Text = Session["Groomer"].ToString();
            TXTBXBRANCH3.Text = Session["Branch"].ToString();
            //** Pet 4
            TXTBXCUSTIDNAME4.Text = Session["CustomerID"].ToString();
            TXTBXJOBDATE4.Text = Session["DatePick"].ToString();
            TXTBXGROOMER4.Text = Session["Groomer"].ToString();
            TXTBXBRANCH4.Text = Session["Branch"].ToString();
            TXTBXPETID.Text = DRPPETNAME.SelectedValue.ToString();
        }
        else{
            //Display list for DRPJOBTYPE dropdownlist
            string queryJobType = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE, queryJobType, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE.Items.Insert(0, new ListItem("Select Job", "0"));

            //Display list for DRPJOBTYPE2 dropdownlist
            string queryJobType2 = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE2, queryJobType2, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE2.Items.Insert(0, new ListItem("Select Job", "0"));

            //Display list for DRPJOBTYPE3 dropdownlist
            string queryJobType3 = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE3, queryJobType3, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE3.Items.Insert(0, new ListItem("Select Job", "0"));

            //Display list for DRPJOBTYPE4 dropdownlist
            string queryJobType4 = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE4, queryJobType4, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE4.Items.Insert(0, new ListItem("Select Job", "0"));

            TXTBXPETID.Text = DRPPETNAME.SelectedValue.ToString();
        }
        if (Session["PetNumber"] != null)
        {
            if (Convert.ToInt32(Session["PetNumber"].ToString()) == 1)
            {
                PHOLDER1.Visible = true;
            }
            else if (Convert.ToInt32(Session["PetNumber"].ToString()) == 2)
            {
                PHOLDER1.Visible = true;
                PHOLDER2.Visible = true;
            }
            else if (Convert.ToInt32(Session["PetNumber"].ToString()) == 3)
            {
                PHOLDER1.Visible = true;
                PHOLDER2.Visible = true;
                PHOLDER3.Visible = true;
            }
            else if (Convert.ToInt32(Session["PetNumber"].ToString()) == 4)
            {
                PHOLDER1.Visible = true;
                PHOLDER2.Visible = true;
                PHOLDER3.Visible = true;
                PHOLDER4.Visible = true;
            }
        }
        
    }

    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        TXTBXPETID.Text = DRPPETNAME.SelectedValue.ToString();
    }

    //Genaral Function to populate dropdownlist
    private void BindDropDownList(DropDownList DRP, string query, string text, string value, string defaultText)
    {
        cmd = new SqlCommand(query);
        using (SqlConnection con = new SqlConnection(connstr))
        {
            //using (SqlDataAdapter sda = new SqlDataAdapter())
            //{
                cmd.Connection = con;
                con.Open();
                DRP.DataSource = cmd.ExecuteReader();
                DRP.DataTextField = text;
                DRP.DataValueField = value;
                DRP.DataBind();
                con.Close();
            //}
        }
        DRP.Items.Insert(0, new ListItem(defaultText, "0"));
    }
    private void getPetInfo()
    {

        //display petid in textbox


        //binding petname in ddl



    }
 

    private void Clear()
    {
       
        TXTBXCUSTIDNAME.Text = "";
        TXTBXPETID.Text = "";
        DRPPETNAME.SelectedItem.Text = "";
        TXTBXNOTES.Text = "";
        DRPJOBTYPE.SelectedItem.Text = "";
        TXTBXJOBDATE.Text = "";
        TXTBXJOBTIME.Text = "";
        TXTBXGROOMER.Text = "";
        TXTBXBRANCH.Text = "";
        TXTBXPETTYPE.Text = "";
        TXTBXBREED.Text = "";
        TXTBXHAIRTYPE.Text = "";
        TXTBXWEIGHT.Text = "";
        DRPCOAT.SelectedItem.Text = "";

        TXTBXCUSTIDNAME2.Text = "";
        TXTBXPETID2.Text = "";
        DRPPETNAME2.SelectedItem.Text = "";
        TXTBXNOTES2.Text = "";
        DRPJOBTYPE2.SelectedItem.Text = "";
        TXTBXJOBDATE2.Text = "";
        TXTBXJOBTIME2.Text = "";
        TXTBXGROOMER2.Text = "";
        TXTBXBRANCH2.Text = "";
        TXTBXPETTYPE2.Text = "";
        TXTBXBREED2.Text = "";
        TXTBXHAIRTYPE2.Text = "";
        TXTBXWEIGHT2.Text = "";
        DRPCOAT2.SelectedItem.Text = "";

        TXTBXCUSTIDNAME3.Text = "";
        TXTBXPETID3.Text = "";
        DRPPETNAME3.SelectedItem.Text = "";
        TXTBXNOTES3.Text = "";
        DRPJOBTYPE3.SelectedItem.Text = "";
        TXTBXJOBDATE3.Text = "";
        TXTBXJOBTIME3.Text = "";
        TXTBXGROOMER3.Text = "";
        TXTBXBRANCH3.Text = "";
        TXTBXPETTYPE3.Text = "";
        TXTBXBREED3.Text = "";
        TXTBXHAIRTYPE3.Text = "";
        TXTBXWEIGHT3.Text = "";
        DRPCOAT3.SelectedItem.Text = "";

        TXTBXCUSTIDNAME4.Text = "";
        TXTBXPETID4.Text = "";
        DRPPETNAME4.SelectedItem.Text = "";
        TXTBXNOTES4.Text = "";
        DRPJOBTYPE4.SelectedItem.Text = "";
        TXTBXJOBDATE4.Text = "";
        TXTBXJOBTIME4.Text = "";
        TXTBXGROOMER4.Text = "";
        TXTBXBRANCH4.Text = "";
        TXTBXPETTYPE4.Text = "";
        TXTBXBREED4.Text = "";
        TXTBXHAIRTYPE4.Text = "";
        TXTBXWEIGHT4.Text = "";
        DRPCOAT4.SelectedItem.Text = "";
    }
    protected void BTNBOOK_Click(object sender, EventArgs e)
    {

        if (Convert.ToInt32(Session["PetNumber"] )== 1)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE.Text);
            cmd.Parameters.AddWithValue("@JobTime", Session["TimePick"].ToString());
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT.SelectedItem.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            LBLMESS.Text = "Successfully Booked!";
            Clear();
        }

        else if (Session["PetNumber"] == "2")
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE.Text);
            cmd.Parameters.AddWithValue("@JobTime", Session["TimePick"].ToString());
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT.SelectedItem.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME2.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID2.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES2.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE2.Text);
            cmd.Parameters.AddWithValue("@JobTime", TXTBXJOBTIME2.Text);
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER2.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH2.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE2.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED2.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE2.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT2.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT2.SelectedItem.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            LBLMESS.Text = "Successfully Booked!";
            Clear();
        }

        else if (Session["PetNumber"] == "3")
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE.Text);
            cmd.Parameters.AddWithValue("@JobTime", Session["TimePick"].ToString());
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT.SelectedItem.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME2.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID2.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES2.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE2.Text);
            cmd.Parameters.AddWithValue("@JobTime", TXTBXJOBTIME2.Text);
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER2.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH2.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE2.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED2.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE2.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT2.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT2.SelectedItem.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME3.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID3.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME3.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES3.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE3.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE3.Text);
            cmd.Parameters.AddWithValue("@JobTime", TXTBXJOBTIME3.Text);
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER3.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH3.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE3.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED3.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE3.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT3.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT3.SelectedItem.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
            LBLMESS.Text = "Successfully Booked!";
            Clear();
        }

        else if (Session["PetNumber"] == "4")
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE.Text);
            cmd.Parameters.AddWithValue("@JobTime", Session["TimePick"].ToString());
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT.SelectedItem.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME2.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID2.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES2.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE2.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE2.Text);
            cmd.Parameters.AddWithValue("@JobTime", TXTBXJOBTIME2.Text);
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER2.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH2.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE2.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED2.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE2.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT2.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT2.SelectedItem.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME3.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID3.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME3.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES3.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE3.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE3.Text);
            cmd.Parameters.AddWithValue("@JobTime", TXTBXJOBTIME3.Text);
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER3.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH3.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE3.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED3.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE3.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT3.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT3.SelectedItem.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, JobTime, DateBooked, Groomer, Branch, Status, PetType, Breed, HairType, Weight, CoatCondition) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @JobTime, @DateBooked, @Groomer, @Branch, @Status, @PetType, @Breed, @HairType, @Weight, @CoatCondition)", conn);

            cmd.Parameters.AddWithValue("@CustomerID", TXTBXCUSTIDNAME4.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID4.Text);
            cmd.Parameters.AddWithValue("@PetName", DRPPETNAME4.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES4.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE4.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", TXTBXJOBDATE4.Text);
            cmd.Parameters.AddWithValue("@JobTime", TXTBXJOBTIME4.Text);
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(DateTime.Today.ToString()));
            cmd.Parameters.AddWithValue("@Groomer", TXTBXGROOMER4.Text);
            cmd.Parameters.AddWithValue("@Branch", TXTBXBRANCH4.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            cmd.Parameters.AddWithValue("@PetType", TXTBXPETTYPE4.Text);
            cmd.Parameters.AddWithValue("@Breed", TXTBXBREED4.Text);
            cmd.Parameters.AddWithValue("@HairType", TXTBXHAIRTYPE4.Text);
            cmd.Parameters.AddWithValue("@Weight", TXTBXWEIGHT4.Text);
            cmd.Parameters.AddWithValue("@CoatCondition", DRPCOAT4.SelectedItem.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
            LBLMESS.Text = "Successfully Booked!";
            Clear();
        }
    }


}