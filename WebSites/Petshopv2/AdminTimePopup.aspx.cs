using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

//ako si johana ginayen
public partial class AdminTimePopup : System.Web.UI.Page
{
    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection Conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    public static List<String> GetTime = new List<String>();
    protected void Page_Load(object sender, EventArgs e)
    {
        Conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from BookingDetails where JobDate='" + Session["DatePick"] + "'", Conn);

        SqlDataAdapter newAdapter = new SqlDataAdapter(cmd);
        DataSet newDataSet = new DataSet();
        newAdapter.Fill(newDataSet);

        Conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            foreach (DataRow dr in newDataSet.Tables[0].Rows)
            {
                String SelTime = (String)dr["JobTime"];
                if (SelTime == "09am")
                {
                    btnAdminTimePopup09am.Enabled = false;
                }
                else if (SelTime == "10am")
                {
                    btnAdminTimePopup10am.Enabled = false;
                }
                else if (SelTime == "11am")
                {
                    btnAdminTimePopup11am.Enabled = false;
                }
                else if (SelTime == "12pm")
                {
                    btnAdminTimePopup12pm.Enabled = false;
                }
                else if (SelTime == "01pm")
                {
                    btnAdminTimePopup01pm.Enabled = false;
                }
                else if (SelTime == "02pm")
                {
                    btnAdminTimePopup02pm.Enabled = false;
                }
                else if (SelTime == "03pm")
                {
                    btnAdminTimePopup03pm.Enabled = false;
                }
                else if (SelTime == "04pm")
                {
                    btnAdminTimePopup04pm.Enabled = false;
                }                             
            }

        }
        Conn.Close();
    }

    protected void btnAdminTimePopup09am_Click(object sender, EventArgs e)
    {
        string TimePick09am = "09am";
        Session["TimePick09am"] = TimePick09am;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup10am_Click(object sender, EventArgs e)
    {
        string TimePick10am = "10am";
        Session["TimePick10am"] = TimePick10am;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup11am_Click(object sender, EventArgs e)
    {
        string TimePick11am = "11am";
        Session["TimePick11am"] = TimePick11am;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup12pm_Click(object sender, EventArgs e)
    {
        string TimePick12pm = "12pm";
        Session["TimePick12pm"] = TimePick12pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup01pm_Click(object sender, EventArgs e)
    {
        string TimePick01pm = "01pm";
        Session["TimePick01pm"] = TimePick01pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup02pm_Click(object sender, EventArgs e)
    {
        string TimePick02pm = "02pm";
        Session["TimePick02pm"] = TimePick02pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup03pm_Click(object sender, EventArgs e)
    {
        string TimePick03pm = "03pm";
        Session["TimePick03pm"] = TimePick03pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
    protected void btnAdminTimePopup04pm_Click(object sender, EventArgs e)
    {
        string TimePick04pm = "04pm";
        Session["TimePick04pm"] = TimePick04pm;
        //Response.Redirect("MemberBookAppt.aspx");
    }
}