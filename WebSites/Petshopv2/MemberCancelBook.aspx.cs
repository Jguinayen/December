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

public partial class MemberCancelBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string MEMCANCELBOOK = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(MEMCANCELBOOK);
            SqlDataAdapter da = new SqlDataAdapter("Select * from BookingDetails where Status = 'Cancelled' and CustomerID='" + Session["CustomerID"].ToString() + "'", con);

            DataSet ds1 = new DataSet();
            da.Fill(ds1);

            GridViewCancel.DataSource = ds1;
            GridViewCancel.DataBind();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /*Tell the compiler that the control is rendered
         * explicitly by overriding the VerifyRenderingInServerForm event.*/
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=MemberCancelBook.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridViewCancel.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();

            //StringWriter stringWriter = new StringWriter();
            //HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridViewCancel.HeaderRow.Style.Add("background-color", "#FFFFFF");

            foreach (TableCell tableCell in GridViewCancel.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#A55129";
            }

            foreach (GridViewRow gridViewRow in GridViewCancel.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFF7E7";
                }
            }
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
        
    }
}