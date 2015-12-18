using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookPet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TXTBXDATE.Text = DateTime.Now.ToShortDateString();
        if (IsPostBack != null)
        {
            TXTBXBOOKINGNO.Text = Session["BookingNo"].ToString();
            TXTBXCUSTOMERID.Text = Session["CustomerID"].ToString();
            TXTBXCUSTOMERNAME.Text = Session["CustomerName"].ToString();
        }
    }
    protected void BTNBOOK_Click(object sender, EventArgs e)
    {
        string PetNumber = DRPPETNUMBER.SelectedItem.Text;
        Session["PetNumber"] = PetNumber;
        string Groomer = DRPGROOMER.SelectedItem.Text;
        Session["Groomer"] = Groomer;
        string CustomerID = TXTBXCUSTOMERID.Text;
        Session["CustomerID"] = CustomerID;
        string Branch = DRPBRANCH.SelectedItem.Text;
        Session["Branch"] = Branch;
        string BookingNo = TXTBXBOOKINGNO.Text;
        Session["BookingNo"] = BookingNo;
        string CustomerName = TXTBXCUSTOMERNAME.Text;
        Session["CustomerName"] = CustomerName;

        Response.Redirect("BookPetPopUp.aspx");
    }
}