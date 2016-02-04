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

public partial class MemberHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string MEMBERHISTORY = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(MEMBERHISTORY);
            SqlDataAdapter da = new SqlDataAdapter("Select * from InvoiceTransaction where CustomerID ='" + Session["CustomerID"].ToString() + "'", con);

            DataSet ds1 = new DataSet();
            da.Fill(ds1);

            GridViewHistory.DataSource = ds1;
            GridViewHistory.DataBind();
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
            Response.AppendHeader("content-disposition", "attachment; filename=MemberHistory.xls");
            Response.ContentType = "application/excel";

            System.IO.StringWriter sw = new System.IO.StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            GridViewHistory.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();

            //StringWriter stringWriter = new StringWriter();
            //HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridViewHistory.HeaderRow.Style.Add("background-color", "#FFFFFF");

            foreach (TableCell tableCell in GridViewHistory.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#A55129";
            }

            foreach (GridViewRow gridViewRow in GridViewHistory.Rows)
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