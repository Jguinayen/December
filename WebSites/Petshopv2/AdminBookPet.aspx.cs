﻿using System;
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
            try
            {
                Calendar2.VisibleDate = DateTime.Today;
                FillHolidayDataset();

                //Display list for DRPBRANCH dropdownlist
                string query = "select BranchName, BranchID from Branch";
                BindDropDownList(DRPBRANCH, query, "BranchName", "BranchID", "Select Branch");
                DRPGROOMER.Enabled = false;
                DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
            }
        }
        HtmlLink canonical = new HtmlLink();
        canonical.Href = "http://localhost:57317/AdminHolidayPopup.aspx";
        canonical.Attributes["rel"] = "canonical";
        Page.Header.Controls.Add(canonical);
    }

    //Genaral Function to populate dropdownlist
    private void BindDropDownList(DropDownList DRP, string query, string text, string value, string defaultText)
    {
        try
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
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

    private string connstr =
            System.Web.Configuration.WebConfigurationManager.ConnectionStrings
            ["ConnectionString"].ConnectionString;
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        try
        {
            string DatePick = Calendar2.SelectedDate.ToString("MM/dd/yyyy");
            Session["DatePick"] = DatePick;
            Response.Redirect("AdminTimePopup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
    {
        try
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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }

    protected void DRPBRANCH_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DRPGROOMER.Enabled = false;
            DRPGROOMER.Items.Clear();
            DRPGROOMER.Items.Insert(0, new ListItem("Select Groomer", "0"));

            string branch = (DRPBRANCH.SelectedItem.Text);
            Session["Branch"] = branch;
            if (!string.IsNullOrEmpty(branch))
            {
                string query = string.Format("select  GroomerID, UserName  from BranchGroomer where BranchName= '{0}'", branch);

                BindDropDownList(DRPGROOMER, query, "Username", "GroomerID", "Select Groomer");
                DRPGROOMER.Enabled = true;
                FillHolidayDataset();
            }
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void DRPGROOMER_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string Groomer = (DRPGROOMER.SelectedItem.Text);
            Session["Groomer"] = Groomer;
            FillHolidayDataset();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void DRPPETNUMBER_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string Petnumber = (DRPPETNUMBER.SelectedItem.Text);
            Session["PetNumber"] = Petnumber;
            FillHolidayDataset();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
}