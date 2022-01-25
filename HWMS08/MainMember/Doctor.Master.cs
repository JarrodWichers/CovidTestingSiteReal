using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HWMS08.Doctor
{
    public partial class Doctor : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == true)
            {

            }
            else
            {
                if(Session["MainMemberUserDetails"] != null)
                {
                     DataTable dt = Session["MainMemberUserDetails"] as DataTable;
                string doctorName = dt.Rows[0]["FullName"].ToString();
                string doctorLastName = dt.Rows[0]["Surname"].ToString();
                string name = doctorName+" "+doctorLastName;

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