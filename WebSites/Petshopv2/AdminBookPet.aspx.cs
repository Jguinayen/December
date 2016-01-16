using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.UI.HtmlControls;

public partial class AdminBookPet : System.Web.UI.Page
{
    protected DataSet dsHolidays;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtAdminBookPetDate.Visible = true;
            Calendar2.VisibleDate = DateTime.Today;
            FillHolidayDataset();
        }
        HtmlLink canonical = new HtmlLink();
        canonical.Href = "http://localhost:57317/AdminHolidayPopup.aspx";
        canonical.Attributes["rel"] = "canonical";
        Page.Header.Controls.Add(canonical);
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
        cs = ConfigurationManager.ConnectionStrings["petshoppeConnstr"];
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

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        
        string DatePick = Calendar2.SelectedDate.ToString("dd/MM/yyyy");
        Session["DatePick"] = DatePick;
        txtAdminBookPetDate.Text = DatePick;
        Response.Redirect("AdminTimePopup.aspx");
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
}