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

public partial class MemberBookAppt : System.Web.UI.Page
{
<<<<<<< HEAD
=======
    
>>>>>>> dfb51fbf71734cf4e1a4edfd19bf93b41a04f1f1
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        
        //Display Session Details
        TXTBXCUSTOMERID.Text = Session["CustomerID"].ToString();
        TXTBXCUSTOMERNAME.Text = Session["UserName"].ToString();

<<<<<<< HEAD
        // getData(this.User.Identity.Name);
=======
>>>>>>> dfb51fbf71734cf4e1a4edfd19bf93b41a04f1f1
        if (!IsPostBack)
        {
            //Display list for DRPBRANCH dropdownlist
            string query = "select BranchName, BranchID from Branch";
            BindDropDownList(DRPBRANCH, query, "BranchName", "BranchID", "Select Branch");
            DRPGROOMER.Enabled = false;
            DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));
        }
<<<<<<< HEAD
    }

=======

    }

    //Genaral Function to populate dropdownlist
>>>>>>> dfb51fbf71734cf4e1a4edfd19bf93b41a04f1f1
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
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("Select * from PetDetails where CustomerID='" + Session["CustomerID"] + "'", conn);

        SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        DataSet newDataSet = new DataSet();
        newAdapter.Fill(newDataSet);

        conn.Open();
<<<<<<< HEAD
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            Response.Redirect("BookPetPopUp.aspx");
        }
        else
        {
            Response.Write("<script>alert('" + "Error! You have no registered pets. You need to register a pet first!" + "')</script>");
            Response.Redirect("MemberRegisterPet.aspx");
        }
        conn.Close();
    }


    protected void DRPBRANCH_SelectedIndexChanged(object sender, EventArgs e)
    {
        //PopulateDRPGROOMER();
=======
        if (cmd.ExecuteNonQuery() == 1)
        {
            Response.Redirect("BookPetPopUp.aspx");
        }
        //else
        //{

        //}
       // string cmdSrch4Pet = "Select count(*) from PetDetails where CustomerID=CustomerID";
       // SqlCommand userExist=new SqlCommand(cmdSrch4Pet, conn);
       // int temp=Convert.ToInt32(userExist.ExecuteScalar().ToString());
        
       // conn.Close();
       // if (temp==1)
       // {
       //     Response.Redirect("BookPetPopUp.aspx");
       // } 
       //else 
       // {
       //     Response.Write("<script>alert('" + "Error! You have no registered pets. You need to register a pet first!" + "')</script>");
       // }
            

        //conn = new SqlConnection(connstr);
        //cmd = new SqlCommand("Select * from PetDetails where CustomID='"+Session[CustomerID]+"'", conn);

        //SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        //DataSet newDataSet = new DataSet();
        //newAdapter.Fill(newDataSet);

        //conn.Open();
        //rdr = cmd.ExecuteReader();

        //string ResultPet = newDataSet.Tables[0].Rows[0]["PetName"].ToString();
        //string SearchCustomer = newDataSet.Tables[0].Rows[0]["CustomID"].ToString();

        //if (SearchCustomer == CustomerID)
        //{
        //    if (rdr.HasRows)
        //    {
        //        Response.Redirect("BookPetPopUp.aspx");
        //        TextBox1.Text = SearchCustomer;
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('" + "Error! You have no registered pets. You need to register a pet first!" + "')</script>");
        //    } 
        //}
        //conn.Close(); 
    }

    //Event to populate DRPGROOMER dropdownlist
    protected void DRPBRANCH_SelectedIndexChanged(object sender, EventArgs e)
    {
        
>>>>>>> dfb51fbf71734cf4e1a4edfd19bf93b41a04f1f1
        DRPGROOMER.Enabled = false;
        DRPGROOMER.Items.Clear();
        DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));

        string branch = (DRPBRANCH.SelectedItem.Text);
        if ( !string.IsNullOrEmpty(branch) )
        {
<<<<<<< HEAD
           //string query = "select Branch, UserName from AdminUsers where BranchID==@BranchID";
=======
>>>>>>> dfb51fbf71734cf4e1a4edfd19bf93b41a04f1f1
           string query = string.Format("select  GroomerID, UserName  from BranchGroomer where BranchName= '{0}'", branch);

           BindDropDownList(DRPGROOMER, query, "Username", "GroomerID", "Select Groomer");
           DRPGROOMER.Enabled = true;
        }
    }
}