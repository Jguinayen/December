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
    protected DataSet dsHolidays;
    protected void Page_Load(object sender, EventArgs e)
    {
        Calendar2.Enabled = false;
        if (!IsPostBack)
        {
            Calendar2.Enabled = false;
            Calendar2.VisibleDate = DateTime.Today;
            FillHolidayDataset();

            //Display list for DRPBRANCH dropdownlist
            string query = "select BranchName, BranchID from Branch";
            BindDropDownList(DRPBRANCH, query, "BranchName", "BranchID", "Select Branch");
            DRPGROOMER.Enabled = false;
            DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));
        }
    }

    //Genaral Function to populate dropdownlist
    private void BindDropDownList(DropDownList DRP, string query, string text, string value, string defaultText)
    {
        string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
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

    protected void FillHolidayDataset()
    {
        DateTime firstDate = new DateTime(Calendar2.VisibleDate.Year,
            Calendar2.VisibleDate.Month, 1);
        DateTime lastDate = GetFirstDayOfNextMonth();
        dsHolidays = GetCurrentMonthData(firstDate, lastDate);
    }

    protected DateTime GetFirstDayOfNextMonth()
    {
        int monthNumber, yearNumber;
        if (Calendar2.VisibleDate.Month == 12)
        {
            monthNumber = 1;
            yearNumber = Calendar2.VisibleDate.Year + 1;
        }
        else
        {
            monthNumber = Calendar2.VisibleDate.Month + 1;
            yearNumber = Calendar2.VisibleDate.Year;
        }
        DateTime lastDate = new DateTime(yearNumber, monthNumber, 1);
        return lastDate;
    }

    protected DataSet GetCurrentMonthData(DateTime firstDate, DateTime lastDate)
    {
        DataSet dsMonth = new DataSet();
        ConnectionStringSettings cs;
        cs = ConfigurationManager.ConnectionStrings["ConnectionString"];
        String connString = cs.ConnectionString;
        SqlConnection dbConnection = new SqlConnection(connString);
        String query;
        query = "SELECT Holidays_Dayoff FROM AdminCalendar " + " WHERE Holidays_Dayoff >= @firstDate AND Holidays_Dayoff < @lastDate";
        SqlCommand dbCommand = new SqlCommand(query, dbConnection);
        dbCommand.Parameters.Add(new SqlParameter("@firstDate",
            firstDate));
        dbCommand.Parameters.Add(new SqlParameter("@lastDate", lastDate));

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(dbCommand);
        try
        {
            sqlDataAdapter.Fill(dsMonth);
        }
        catch { }
        return dsMonth;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        //string DatePick = Calendar2.SelectedDate.ToString("MM/dd/yyyy");
        //Session["DatePick"] = DatePick;
        //Response.Redirect("MemberTimePopup.aspx");

        if (Calendar2.Enabled == true)
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
                string DatePick = Calendar2.SelectedDate.ToString("MM/dd/yyyy");
                Session["DatePick"] = DatePick;
                Response.Redirect("MemberTimePopup.aspx");
            }
            else
            {
                Response.Write("<script>alert('" + "Error! You have no registered pets. You need to register a pet first!" + "')</script>");
                Response.Redirect("MemberRegisterPet.aspx");
            }
            conn.Close();
        }
    }

    private string connstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    //Event to populate DRPGROOMER dropdownlist
    protected void DRPBRANCH_SelectedIndexChanged(object sender, EventArgs e)
    {
        Calendar2.Enabled = true;
        DRPGROOMER.Enabled = false;
        DRPGROOMER.Items.Clear();
        DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));

        string branch = (DRPBRANCH.SelectedItem.Text);
        if (!string.IsNullOrEmpty(branch))
        {
            string query = string.Format("select  GroomerID, UserName  from BranchGroomer where BranchName= '{0}'", branch);

            BindDropDownList(DRPGROOMER, query, "Username", "GroomerID", "Select Groomer");
            DRPGROOMER.Enabled = true;
            string Branch = (DRPBRANCH.SelectedItem.Text);
            Session["Branch"] = Branch;
        }
    }
    protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.IsOtherMonth || e.Day.Date < (System.DateTime.Now.AddDays(-1)))
        {
            e.Day.IsSelectable = false;
            e.Cell.ToolTip = "Not Available";
        }
        DateTime nextDate;
        if (dsHolidays != null)
        {
            foreach (DataRow dr in dsHolidays.Tables[0].Rows)
            {
                nextDate = (DateTime)dr["Holidays_Dayoff"];
                if (nextDate == e.Day.Date)
                {
                    e.Day.IsSelectable = false;
                    e.Cell.BackColor = System.Drawing.Color.Red;
                    e.Cell.ForeColor = System.Drawing.Color.White;
                    e.Cell.ToolTip = "Not Available";
                    e.Cell.Controls.Add(new LiteralControl("<br/>Holidays / Day Off<br/>"));// + Notes));
                }
            }
        }
    }
    protected void DRPGROOMER_SelectedIndexChanged(object sender, EventArgs e)
    {
        Calendar2.Enabled = true;
        string Groomer = (DRPGROOMER.SelectedItem.Text);
        Session["Groomer"] = Groomer;
        FillHolidayDataset();
    }
    protected void DRPPETNUMBER_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string PetNumber = (DRPPETNUMBER.SelectedItem.Text);
        Session["PetNumber"] = PetNumber;
        FillHolidayDataset();
        Calendar2.Enabled = true;
    }
}