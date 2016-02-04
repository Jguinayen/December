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
            ["ConnectionString"].ConnectionString;
    private SqlConnection Conn;
    private SqlCommand cmd;
    private SqlDataReader rdr;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Visible = false;
            Conn = new SqlConnection(connstr);
            cmd = new SqlCommand("select * from BookingDetails where JobDate='" + Session["DatePick"].ToString() + "'", Conn);

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
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }

    protected void btnAdminTimePopup09am_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "09am";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup10am_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "10am";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup11am_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "11am";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup12pm_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "12pm";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup01pm_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "01pm";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup02pm_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "02pm";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup03pm_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "03pm";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
    protected void btnAdminTimePopup04pm_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdminTimePopupTimePick.Text = "04pm";
            Session["TimePick"] = txtAdminTimePopupTimePick.Text;
            Response.Redirect("AdminBookPetPopoup.aspx");
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
}