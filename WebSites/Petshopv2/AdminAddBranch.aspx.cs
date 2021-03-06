﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminAddBranch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string connstr =
           System.Web.Configuration.WebConfigurationManager.ConnectionStrings
           ["ConnectionString"].ConnectionString;
    private SqlConnection conn;
    private SqlCommand cmd;

    protected void BTNSAVEBRANCH_Click(object sender, EventArgs e)
    {
        try
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Insert into Branch (BranchName) values (@BranchName)", conn);

            cmd.Parameters.AddWithValue("@BranchName", TXTBRANCH.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery()==1)
            {
                LBLMESS.Text = " Branch Successfully Added!";
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
        }
    }
}