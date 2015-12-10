using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public partial class Admin : System.Web.UI.Page
{
    protected DataSet dsHolidays;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Calendar1.VisibleDate = DateTime.Today;
            FillHolidayDataset();
            lblAdminCalID.Text = Session["UserName"].ToString();
            
        }
        lblAdminCalBlockDate.Visible = false;
        txtAdminCalBlockDate.Visible = false;
        grdviewAdminCalendar.Visible = false;
        lblAdminCalID.Visible = true;
    }

    protected void clear()
    {
        txtAdminCalName.Text = "";
        txtAdminCalBlockDate.Text = "";
        txtAdminCalNotes.Text = "";
    }
    protected void FillHolidayDataset()
    {
        DateTime firstDate = new DateTime(Calendar1.VisibleDate.Year,
            Calendar1.VisibleDate.Month, 1);
        DateTime lastDate = GetFirstDayOfNextMonth();
        dsHolidays = GetCurrentMonthData(firstDate, lastDate);
    }

    protected DateTime GetFirstDayOfNextMonth()
    {
        int monthNumber, yearNumber;
        if (Calendar1.VisibleDate.Month == 12)
        {
            monthNumber = 1;
            yearNumber = Calendar1.VisibleDate.Year + 1;
        }
        else
        {
            monthNumber = Calendar1.VisibleDate.Month + 1;
            yearNumber = Calendar1.VisibleDate.Year;
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

    public static List<DateTime> list = new List<DateTime>();
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        if (Session["SelectedDates"] != null)
        {
            List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
            foreach (DateTime dt in newList)
            {
                Calendar1.SelectedDates.Add(dt);

            }
            list.Clear();
        }
    }
    
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.IsSelected == true)
        {
            list.Add(e.Day.Date);
        }
        Session["SelectedDates"] = list;
        FillHolidayDataset();

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
                    e.Cell.Controls.Add(new LiteralControl("<br/>Holiday / Day Off <br/>"));// + TextBox1.text));
                }
            }
        }
    }
    protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
    {
        FillHolidayDataset();
    }

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["petshoppeConnstr"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    protected void btnAdminCalBlockDates_Click(object sender, EventArgs e)
    {
        if (Session["SelectedDates"] != null)
        {
            List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
             foreach (DateTime dt in newList)
            {
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand("Insert into AdminCalendar (Name, Holidays_Dayoff, Notes) values (@Name, @Holidays_Dayoff, @Notes)", conn);

                cmd.Parameters.AddWithValue("@Name", txtAdminCalName.Text);
                cmd.Parameters.AddWithValue("@Holidays_Dayoff", dt);
                cmd.Parameters.AddWithValue("@Notes", txtAdminCalNotes.Text);

                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    FillHolidayDataset();
                    Calendar1.SelectedDates.Clear();
                    //Calendar1.SelectedDates.Remove(Calendar1.SelectedDates[0]);
                    Session.RemoveAll();
                    //string display = "Pop-up!";
                    //ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + display + "');", true);
                }
                conn.Close();
            }
             newList.Clear();
        }
    }
    protected void btnAdminCalViewBlockDates_Click(object sender, EventArgs e)
    {
        List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
        newList.Clear();
        grdviewAdminCalendar.Visible = true;
        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from AdminCalendar", conn);

        System.Data.DataTable dt = new System.Data.DataTable();

        conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            dt.Load(rdr);
            grdviewAdminCalendar.DataSource = dt;
            grdviewAdminCalendar.DataBind();
        }
        else
        {
            dt.Load(rdr);
            grdviewAdminCalendar.DataSource = dt;
            grdviewAdminCalendar.EmptyDataText = "No Record Found";
            grdviewAdminCalendar.DataBind();
        }
        FillHolidayDataset();
        conn.Close();
    
    }
    protected void btnAdminCalEdit_Click(object sender, EventArgs e)
    {
        List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
        newList.Clear();
        lblAdminCalBlockDate.Visible = true;
        txtAdminCalBlockDate.Visible = true;
        grdviewAdminCalendar.Visible = true;

        conn = new SqlConnection(connstr);
        cmd = new SqlCommand("select * from AdminCalendar", conn);

        System.Data.DataTable dt = new System.Data.DataTable();

        conn.Open();
        rdr = cmd.ExecuteReader();

        if (rdr.HasRows)
        {
            dt.Load(rdr);
            grdviewAdminCalendar.DataSource = dt;
            grdviewAdminCalendar.DataBind();
            clear();
        }
        else
        {
            dt.Load(rdr);
            grdviewAdminCalendar.DataSource = dt;
            grdviewAdminCalendar.EmptyDataText = "No Record Found";
            grdviewAdminCalendar.DataBind();
        }
        FillHolidayDataset();
        conn.Close();
        clear();
    }
    protected void btnAdminCalSaveChanges_Click(object sender, EventArgs e)
    {
        try
        {
            List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
            newList.Clear();
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("update AdminCalendar set Name=@Name, Holidays_Dayoff=@Holidays_Dayoff, Notes=@Notes where AdminUserID=@AdminUserID", conn);

            cmd.Parameters.AddWithValue("@AdminUserID", lblAdminCalID.Text);
            cmd.Parameters.AddWithValue("@Name", txtAdminCalName.Text);
            cmd.Parameters.AddWithValue("@Holidays_Dayoff", Convert.ToDateTime(txtAdminCalBlockDate.Text));
            cmd.Parameters.AddWithValue("@Notes", txtAdminCalNotes.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                FillHolidayDataset();
                clear();
            }
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
            FillHolidayDataset();
            clear();
        }
        
        conn.Close();
    }
    protected void grdviewAdminCalendar_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
        newList.Clear();
        Calendar1.SelectedDates.Clear();
        int rowIndex = grdviewAdminCalendar.SelectedIndex;
        lblAdminCalID.Text = grdviewAdminCalendar.SelectedRow.Cells[1].Text;
        txtAdminCalName.Text = grdviewAdminCalendar.SelectedRow.Cells[2].Text;
        txtAdminCalBlockDate.Text = grdviewAdminCalendar.SelectedRow.Cells[3].Text;
        txtAdminCalNotes.Text = grdviewAdminCalendar.SelectedRow.Cells[4].Text;

        lblAdminCalName.Visible = true;
        lblAdminCalBlockDate.Visible = true;
        lblAdminCalNotes.Visible = true;
        txtAdminCalName.Visible = true;
        txtAdminCalBlockDate.Visible = true;
        txtAdminCalNotes.Visible = true;
        FillHolidayDataset();
    }
}