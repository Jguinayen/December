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
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        
        //Display Session Details
        TXTBXCUSTOMERID.Text = Session["CustomerID"].ToString();
        TXTBXCUSTOMERNAME.Text = Session["UserName"].ToString();

        // getData(this.User.Identity.Name);
        if (!IsPostBack)
        {
            string query = "select BranchName, BranchID from Branch";
            BindDropDownList(DRPBRANCH, query, "BranchName", "BranchID", "Select Branch");
            DRPGROOMER.Enabled = false;
            DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));
        }
    }

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
        DRPGROOMER.Enabled = false;
        DRPGROOMER.Items.Clear();
        DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));

        string branch = (DRPBRANCH.SelectedItem.Text);
        if ( !string.IsNullOrEmpty(branch) )
        {
           //string query = "select Branch, UserName from AdminUsers where BranchID==@BranchID";
           string query = string.Format("select  GroomerID, UserName  from BranchGroomer where BranchName= '{0}'", branch);

           BindDropDownList(DRPGROOMER, query, "Username", "GroomerID", "Select Groomer");
           DRPGROOMER.Enabled = true;
        }
    }
}