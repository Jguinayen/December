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
    //get customer details from table to be displayed on page upon loading

    //private void getData(string user)
    //{
    //    DataTable dt = new DataTable();
    //    SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\OEM\Desktop\FinalDecember\December\WebSites\Petshopv2\App_Data\Database.mdf;Integrated Security=True");
    //    connection.Open();
    //    SqlCommand sqlCmd = new SqlCommand("SELECT * from CustomerDetails WHERE Email = @Email", connection);
    //    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

    //    sqlCmd.Parameters.AddWithValue("@Email",Session["Email"]);
    //    sqlDa.Fill(dt);
    //    if (dt.Rows.Count > 0)
    //    {
    //        TXTBXCUSTOMERID.Text = dt.Rows[0]["CustomerID"].ToString(); //Where ColumnName is the Field from the DB that you want to display 
    //        TXTBXCUSTOMERNAME.Text = dt.Rows[0]["Firstname"+"Lastname"].ToString();

    //    }
    //    connection.Close();
    //} 

    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        
        //Display Session Details
        TXTBXCUSTOMERID.Text = Session["CustomerID"].ToString();
        TXTBXCUSTOMERNAME.Text = Session["UserName"].ToString();


        // getData(this.User.Identity.Name);
//copied today
        if (!IsPostBack)
        {
            string query = "select Branch, BranchID from AdminUsers";
            BindDropDownList(DRPBRANCH, query, "Branch", "BranchID", "Select Branch");
            DRPGROOMER.Enabled = false;
            DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));

        }
//until here
    }
//copied today
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
//until here
    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    protected void BTNBOOK_Click(object sender, EventArgs e)
    {
        //pass session details to BookPetPopUp page and load said page
        string PetNumber = DRPPETNUMBER.SelectedItem.Text;
        Session["PetNumber"] = PetNumber;
        string Groomer = DRPGROOMER.SelectedItem.Text;
        Session["Groomer"] = Groomer;
        string CustomerID = TXTBXCUSTOMERID.Text;
        Session["CustomerID"] = CustomerID;
        string Branch = DRPBRANCH.SelectedItem.Text;
        Session["Branch"] = Branch;
        string CustomerName = TXTBXCUSTOMERNAME.Text;
        Session["CustomerName"] = CustomerName;

        conn.Open();
        string cmdSrch4Pet = "Select count(*) from PetDetails where CustomerID=CustomerID";
        SqlCommand userExist=new SqlCommand(cmdSrch4Pet, conn);
        int temp=Convert.ToInt32(userExist.ExecuteScalar().ToString());
        
        conn.Close();
        if (temp==1)
        {
            Response.Redirect("BookPetPopUp.aspx");
        } 
       else 
        {
            Response.Write("<script>alert('" + "Error! You have no registered pets. You need to register a pet first!" + "')</script>");
        }
            

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

    //public void PopulateDRPGROOMER()
    //{
    //    var SelectedBranch = DRPBRANCH.SelectedValue;
        
    //    SqlCommand cmd = new SqlCommand("SELECT * FROM AdminUsers WHERE Branch = SelectedBranch", new SqlConnection(ConfigurationManager.AppSettings["petshoppeConnstr"]));
    //    cmd.Connection.Open();

    //    SqlDataReader ddlValues;
    //    ddlValues = cmd.ExecuteReader();

    //    DRPGROOMER.DataSource = ddlValues;
    //    DRPGROOMER.DataValueField = "UserName";
    //    DRPGROOMER.DataTextField = "UserType";
    //    DRPGROOMER.DataBind();

    //    cmd.Connection.Close();
    //    cmd.Connection.Dispose();
    //}
    protected void DRPBRANCH_SelectedIndexChanged(object sender, EventArgs e)
    {
        //PopulateDRPGROOMER();

        DRPGROOMER.Enabled = false;
        DRPGROOMER.Items.Clear();
        DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));
        int branch = int.Parse(DRPBRANCH.SelectedItem.Value);
        if (branch > 0)
        {
            string query = string.Format("select UserName, AdminUserID from AdminUsers where BranchID = {0}", branch);
            BindDropDownList(DRPGROOMER, query,  "UserName", "AdminUserID", "Select Groomer");
            DRPGROOMER.Enabled = true;
        }
    }
}