using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;


public partial class AdminTimePopup : System.Web.UI.Page
{
    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection Conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["DatePick"].ToString();
        Conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from BookingDetails where JobDate='" + TextBox1.Text + "'", Conn);

        SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        DataSet newDataSet = new DataSet();
        newAdapter.Fill(newDataSet);

        Conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            //foreach (DataRow dr in newDataSet.Tables[0].Rows)
            //{
            //    String SelTime = (String)dr["JobTime"];
            //    if (SelTime == "09am" || SelTime == "10am")
            //    {
            //        btnAdminTimePopup09am.Enabled = false;
            //        btnAdminTimePopup10am.Enabled = false;
            //    }
            //}

            string SelDate = newDataSet.Tables[0].Rows[0]["JobDate"].ToString();
            string SelTime = newDataSet.Tables[0].Rows[0]["JobTime"].ToString();


            if (TextBox1.Text == SelDate & SelTime == "09am")
            {
                btnAdminTimePopup09am.Enabled = false;
            }
            else if(TextBox1.Text == SelDate & SelTime == "10am")
            {
                btnAdminTimePopup10am.Enabled = false;
            }


            
            
        }
        Conn.Close();
    }

    protected void btnAdminTimePopup09am_Click(object sender, EventArgs e)
    {
        string TimePick09am = "09am";
        Session["TimePick09am"] = TimePick09am;
        TextBox1.Text = TimePick09am;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup10am_Click(object sender, EventArgs e)
    {
        string TimePick10am = "10am";
        Session["TimePick10am"] = TimePick10am;
        TextBox1.Text = TimePick10am;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup11am_Click(object sender, EventArgs e)
    {
        string TimePick11am = "11am";
        Session["TimePick11am"] = TimePick11am;
        TextBox1.Text = TimePick11am;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup12pm_Click(object sender, EventArgs e)
    {
        string TimePick12pm = "12pm";
        Session["TimePick12pm"] = TimePick12pm;
        TextBox1.Text = TimePick12pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup01pm_Click(object sender, EventArgs e)
    {
        string TimePick01pm = "01pm";
        Session["TimePick01pm"] = TimePick01pm;
        TextBox1.Text = TimePick01pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup02pm_Click(object sender, EventArgs e)
    {
        string TimePick02pm = "02pm";
        Session["TimePick02pm"] = TimePick02pm;
        TextBox1.Text = TimePick02pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup03pm_Click(object sender, EventArgs e)
    {
        string TimePick03pm = "03pm";
        Session["TimePick03pm"] = TimePick03pm;
        TextBox1.Text = TimePick03pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup04pm_Click(object sender, EventArgs e)
    {
        string TimePick04pm = "04pm";
        Session["TimePick04pm"] = TimePick04pm;
        TextBox1.Text = TimePick04pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
}