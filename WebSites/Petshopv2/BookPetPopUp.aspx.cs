using System;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        //if (IsPostBack != null)
        //{
        LBLCUSTOMERID.Text = "2222";//Session["CustomerID"].ToString();
        
          //  LBLCUSTOMERNAME.Text = Session["CustomerName"].ToString();
        //    TXTBXGROOMER.Text = Session["Groomer"].ToString();
        //    TXTBXBRANCH.Text = Session["Branch"].ToString();
        //    //TXTBXGROOMER2.Text = Session["Groomer"].ToString();
        //    //TXTBXBRANCH2.Text = Session["Branch"].ToString();
        //    //TXTBXGROOMER3.Text = Session["Groomer"].ToString();
        //    //TXTBXBRANCH3.Text = Session["Branch"].ToString();
        //    //TXTBXGROOMER4.Text = Session["Groomer"].ToString();
        //    //TXTBXBRANCH4.Text = Session["Branch"].ToString();
        //}

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


        if (!IsPostBack)
        {
            //Display list for DRPPETNAME dropdownlist
            string queryPetName = "select PetName, PetID from PetDetails where CustomerID=CustomerID";
            BindDropDownList(DRPPETNAME, queryPetName, "PetName", "PetID", "Select Pet");
            DRPPETNAME.Items.Insert(0, new ListItem("Select Pet", "0"));

            //Display list for DRPJOBTYPE dropdownlist
            string queryJobType = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE, queryJobType, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE.Items.Insert(0, new ListItem("Select Job", "0"));

            //Display list for DRPPETNAME2 dropdownlist
            string queryPetName2 = "select PetName, PetID from PetDetails";
            BindDropDownList(DRPPETNAME2, queryPetName2, "PetName", "PetID", "Select Pet");
            DRPPETNAME2.Items.Insert(0, new ListItem("Select Pet", "0"));

            //Display list for DRPJOBTYPE2 dropdownlist
            string queryJobType2 = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE2, queryJobType2, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE2.Items.Insert(0, new ListItem("Select Job", "0"));

            //Display list for DRPPETNAME3 dropdownlist
            string queryPetName3 = "select PetName, PetID from PetDetails";
            BindDropDownList(DRPPETNAME3, queryPetName3, "PetName", "PetID", "Select Pet");
            DRPPETNAME3.Items.Insert(0, new ListItem("Select Pet", "0"));

            //Display list for DRPJOBTYPE3 dropdownlist
            string queryJobType3 = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE3, queryJobType3, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE3.Items.Insert(0, new ListItem("Select Job", "0"));

            //Display list for DRPPETNAME4 dropdownlist
            string queryPetName4 = "select PetName, PetID from PetDetails";
            BindDropDownList(DRPPETNAME4, queryPetName4, "PetName", "PetID", "Select Pet");
            DRPPETNAME4.Items.Insert(0, new ListItem("Select Pet", "0"));

            //Display list for DRPJOBTYPE4 dropdownlist
            string queryJobType4 = "select JobType, JobTypeID from JobTypeTable";
            BindDropDownList(DRPJOBTYPE4, queryJobType4, "JobType", "JobTypeID", "Select Job");
            DRPJOBTYPE4.Items.Insert(0, new ListItem("Select Job", "0"));
        }

    }

    //Genaral Function to populate dropdownlist
    private void BindDropDownList(DropDownList DRP, string query, string text, string value, string defaultText)
    {
        string conString = ConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
        SqlCommand cmd = new SqlCommand(query);
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;
                con.Open();
                DRP.DataSource = cmd.ExecuteReader();
                DRP.DataTextField = text;
                DRP.DataValueField = value;
                DRP.DataBind();
                con.Close();
            }
        }
        DRP.Items.Insert(0, new ListItem(defaultText, "0"));
    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

   
    protected void BTNBOOK_Click(object sender, EventArgs e)
    {
        //if (Session["Petnumber"].ToString() == "1")
        //{
       
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, DateBooked, Groomer, Branch, Status) values(@CustomerID, @PetID, @PetName, @Notes, @JobType, @JobDate, @DateBooked, @Groomer, @Branch, @Status)", conn);

            //bernard d ko pa nagawa tong pagdisplay ng PETID ng naselect na PetName
            //string queryPetID = "select PetID from PetDetails where PetName=DRPPETNAME.SelectedItem.text";
            //TXTBXPETID.Text = queryPetID;
           
            cmd.Parameters.AddWithValue("@CustomerID", LBLCUSTOMERID.Text);
            cmd.Parameters.AddWithValue("@PetID", TXTBXPETID.Text);
            cmd.Parameters.AddWithValue("@PetName",DRPPETNAME.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Notes", TXTBXNOTES.Text);
            cmd.Parameters.AddWithValue("@JobType", DRPJOBTYPE.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@JobDate", Convert.ToDateTime(TXTBXDATE.Text));//bernard palitan mo to kc temp lng to para lng matest ko. Ung date na dabapt masave sa colum na to eh ung pinindot ng user sa calendar.
            cmd.Parameters.AddWithValue("@DateBooked", Convert.ToDateTime(TXTBXDATE.Text));
            cmd.Parameters.AddWithValue("@Groomer", Session["Groomer"] = TXTBXGROOMER.Text);
            cmd.Parameters.AddWithValue("@Branch", Session["Branch"] = TXTBXBRANCH.Text);
            cmd.Parameters.AddWithValue("@Status", "upcoming");
            conn.Open();
            cmd.ExecuteNonQuery();
            
        //pet2 insert
            //if (cmd.ExecuteNonQuery() == 1)//dinisable ko to bernard kc dalawang beses nyang sinisave ung unang record hehehe
            //{
            cmd.Parameters.Clear();//sinubukan kong ilagay tong linyang to after ng cmd.Execute.....sa taas bago ung "if" pero nag eerorr kaya nilagay ko d2 kc ok pag d2 sya...
            cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, DateBooked, Groomer, Branch, Status) values(@CustomerID2, @PetID2, @PetName2, @Notes2, @JobType2, @JobDate2, @DateBooked2, @Groomer2, @Branch2, @Status2)", conn);

                //bernard d ko pa nagawa tong pagdisplay ng PETID ng naselect na PetName
                //string queryPetID = "select PetID from PetDetails where PetName=DRPPETNAME.SelectedItem.text";
                //TXTBXPETID.Text = queryPetID;
                
                cmd.Parameters.AddWithValue("@CustomerID2", LBLCUSTOMERID.Text);
                cmd.Parameters.AddWithValue("@PetID2", TXTBXPETID2.Text);
                cmd.Parameters.AddWithValue("@PetName2", DRPPETNAME2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@Notes2", TXTBXNOTES2.Text);
                cmd.Parameters.AddWithValue("@JobType2", DRPJOBTYPE2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@JobDate2", Convert.ToDateTime(TXTBXDATE.Text));//bernard palitan mo to kc temp lng to para lng matest ko. Ung date na dabapt masave sa colum na to eh ung pinindot ng user sa calendar.
                cmd.Parameters.AddWithValue("@DateBooked2", Convert.ToDateTime(TXTBXDATE.Text));
                cmd.Parameters.AddWithValue("@Groomer2", Session["Groomer"] = TXTBXGROOMER2.Text);
                cmd.Parameters.AddWithValue("@Branch2", Session["Branch"] = TXTBXBRANCH2.Text);
                cmd.Parameters.AddWithValue("@Status2", "upcoming");
                cmd.ExecuteNonQuery();
           // }

        //pet3 insert,d na ako naglagay ng if para itest ko muna kung nasasave tong pet3
                cmd.Parameters.Clear();
                cmd = new SqlCommand("Insert into BookingDetails(CustomerID, PetID, PetName, Notes, JobType, JobDate, DateBooked, Groomer, Branch, Status) values(@CustomerID3, @PetID3, @PetName3, @Notes3, @JobType3, @JobDate3, @DateBooked3, @Groomer3, @Branch3, @Status3)", conn);

                //bernard d ko pa nagawa tong pagdisplay ng PETID ng naselect na PetName
                //string queryPetID = "select PetID from PetDetails where PetName=DRPPETNAME.SelectedItem.text";
                //TXTBXPETID.Text = queryPetID;

                cmd.Parameters.AddWithValue("@CustomerID3", LBLCUSTOMERID.Text);
                cmd.Parameters.AddWithValue("@PetID3", TXTBXPETID3.Text);
                cmd.Parameters.AddWithValue("@PetName3", DRPPETNAME3.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@Notes3", TXTBXNOTES3.Text);
                cmd.Parameters.AddWithValue("@JobType3", DRPJOBTYPE3.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@JobDate3", Convert.ToDateTime(TXTBXDATE.Text));//bernard palitan mo to kc temp lng to para lng matest ko. Ung date na dabapt masave sa colum na to eh ung pinindot ng user sa calendar.
                cmd.Parameters.AddWithValue("@DateBooked3", Convert.ToDateTime(TXTBXDATE.Text));
                cmd.Parameters.AddWithValue("@Groomer3", Session["Groomer"] = TXTBXGROOMER3.Text);
                cmd.Parameters.AddWithValue("@Branch3", Session["Branch"] = TXTBXBRANCH3.Text);
                cmd.Parameters.AddWithValue("@Status3", "upcoming");
                cmd.ExecuteNonQuery();
        //d ko muna nilagay ung para sa pet4 kc masyadong mahaba ung code na,mahirap pag magdedebug  ka...

        conn.Close();

    }
            
 
}