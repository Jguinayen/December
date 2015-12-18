using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookPetPopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        if (IsPostBack != null)
        {
            LBLCUSTOMERID.Text = Session["CustomerID"].ToString();
            LBLBOOKINGNO.Text = Session["BookingNo"].ToString();
            LBLFNAME.Text = Session["CustomerName"].ToString();
            TXTBXGROOMER1.Text = Session["Groomer"].ToString();
            TXTBXBRANCH1.Text = Session["Branch"].ToString();
            TXTBXGROOMER2.Text = Session["Groomer"].ToString();
            TXTBXBRANCH2.Text = Session["Branch"].ToString();
            TXTBXGROOMER3.Text = Session["Groomer"].ToString();
            TXTBXBRANCH3.Text = Session["Branch"].ToString();
            TXTBXGROOMER4.Text = Session["Groomer"].ToString();
            TXTBXBRANCH4.Text = Session["Branch"].ToString();
        }
    }
    protected void BTNBOOK_Click(object sender, EventArgs e)
    {

    }
    protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox20_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox24_TextChanged(object sender, EventArgs e)
    {

    }
}