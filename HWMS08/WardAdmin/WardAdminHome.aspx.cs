using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HWMS08.WardAdmin
{
    public partial class WardAdminHome : System.Web.UI.Page
    {
        public static DataTable displayDetails;
        protected void Page_Load(object sender, EventArgs e)
        {
            displayDetails = Session["WardAdminUserDetails"] as DataTable;
            lblName.Text = "Name: " + displayDetails.Rows[0]["FirstName"].ToString() + ' ' + displayDetails.Rows[0]["Surname"].ToString();
            lblEmail.Text = "Email: " + displayDetails.Rows[0]["Email"].ToString();
            lblContactNum.Text = "Contact Number: " + displayDetails.Rows[0]["ContactNum"].ToString();
            lblRole.Text = "Role: " + displayDetails.Rows[0]["Role"].ToString();
        }
    }
}