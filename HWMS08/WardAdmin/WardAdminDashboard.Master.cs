using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HWMS08.WardAdmin
{
    public partial class WardAdminDashboard : System.Web.UI.MasterPage
    {
        public static DataTable dtUserDetails;
        protected void Page_Load(object sender, EventArgs e)
        {
            dtUserDetails = Session["ManagerDetails"] as DataTable;
            lblUserName.Text = dtUserDetails.Rows[0]["FullName"].ToString() + ' ' + dtUserDetails.Rows[0]["Surname"].ToString();
        }
        
    }
}