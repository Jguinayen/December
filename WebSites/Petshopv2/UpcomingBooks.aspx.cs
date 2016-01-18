﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class UpcomingBooks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string UPCOMINGBOOKS = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["petshoppeConnstr"].ConnectionString;

        SqlConnection con = new SqlConnection(UPCOMINGBOOKS);
        SqlDataAdapter da = new SqlDataAdapter("Select * from BookingDetails", con);

        DataSet ds1 = new DataSet();
        da.Fill(ds1);

        GridView1.DataSource = ds1;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.AppendHeader("content-disposition", "attachment;filename=UpcomingBooks.xls");
        Response.ContentType = "application/excel";

        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

        GridView1.HeaderRow.Style.Add("background-color", "#FFFFFF");

        foreach (TableCell tableCell in GridView1.HeaderRow.Cells)
        {
            tableCell.Style["background-color"] = "#A55129";
        }

        foreach (GridViewRow gridViewRow in GridView1.Rows)
        {
            gridViewRow.BackColor = System.Drawing.Color.White;
            foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
            {
                gridViewRowTableCell.Style["background-color"] = "#FFF7E7";
            }
        }

    }
}