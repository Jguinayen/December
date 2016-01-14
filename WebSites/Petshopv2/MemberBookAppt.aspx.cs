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
    //get customer details from table to be displayed on this page upon loading

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

        // getData(this.User.Identity.Name);

        // Customer ID,Customer Name should be displayed upon page load from "Customer Log-In Page" details:

        //if (IsPostBack != null)
        //{
            //Display Session Details

        TXTBXCUSTOMERID.Text = Session["CustomerID"].ToString();
        TXTBXCUSTOMERNAME.Text = Session["UserName"].ToString();
       // }
    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;
    //private SqlConnection conn;
    //private SqlCommand cmd;
    //private SqlDataReader rdr;
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
        //        Response.Write("<script>alert('" + "Error! You have no registered pets. Please register a pet to continue!" + "')</script>");
        //    } 
        //}
        //conn.Close(); 
    }

    public void PopulateDRPGROOMER()
    {
        var SelectedBranch = DRPBRANCH.SelectedValue;
        
        SqlCommand cmd = new SqlCommand("SELECT * FROM AdminUsers WHERE Branch =", new SqlConnection(ConfigurationManager.AppSettings["petshoppeConnstr"]));
        cmd.Connection.Open();

        SqlDataReader ddlValues;
        ddlValues = cmd.ExecuteReader();

        DRPGROOMER.DataSource = ddlValues;
        DRPGROOMER.DataValueField = "UserName";
        DRPGROOMER.DataTextField = "UserType";
        DRPGROOMER.DataBind();

        cmd.Connection.Close();
        cmd.Connection.Dispose();
    }
    protected void DRPBRANCH_SelectedIndexChanged(object sender, EventArgs e)
    {
        PopulateDRPGROOMER();        
    }
}