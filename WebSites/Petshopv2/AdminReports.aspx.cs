using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class AdminReports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ADMINBOOKING = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        SqlConnection con = new SqlConnection(ADMINBOOKING);
        SqlDataAdapter da = new SqlDataAdapter("Select * from BookingDetails where Status = 'Upcoming'", con);

        DataSet ds1 = new DataSet();
        da.Fill(ds1);

        GridViewUpcoming.DataSource = ds1;
        GridViewUpcoming.DataBind();
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /*Tell the compiler that the control is rendered
         * explicitly by overriding the VerifyRenderingInServerForm event.*/
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment; filename=UpcomingBooks.xls");
        Response.ContentType = "application/excel";

        System.IO.StringWriter sw = new System.IO.StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        GridViewUpcoming.RenderControl(htw);
        Response.Write(sw.ToString());
        Response.End();

        //StringWriter stringWriter = new StringWriter();
        //HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

        GridViewUpcoming.HeaderRow.Style.Add("background-color", "#FFFFFF");

        foreach (TableCell tableCell in GridViewUpcoming.HeaderRow.Cells)
        {
            tableCell.Style["background-color"] = "#A55129";
        }

        foreach (GridViewRow gridViewRow in GridViewUpcoming.Rows)
        {
            gridViewRow.BackColor = System.Drawing.Color.White;
            foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
            {
                gridViewRowTableCell.Style["background-color"] = "#FFF7E7";
            }
        }
    }
}