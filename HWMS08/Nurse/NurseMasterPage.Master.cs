using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HWMS08.Nurse
{
    public partial class NurseMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {

            }
            else
            {
                if (Session["NurseUserDetails"] != null)
                {
                    DataTable dt = Session["NurseUserDetails"] as DataTable;
                    string nurseName = dt.Rows[0]["FullName"].ToString();
                    string nurseLastName = dt.Rows[0]["Surname"].ToString();
                    string name = nurseName + " " + nurseLastName;

                    lblUserName.Text = name;
                }
                else
                {
                    lblUserName.Text = "NOT SET";
                }



            }
        }
    }
}