using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data.SqlClient;
using BusinessLogicLayer;
using System.Data;

namespace HWMS08.Doctor
{
    public partial class DoctorDashboard : System.Web.UI.Page
    {
        BusinessLogic bll = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == true)
            {

            }
            else
            {
                GetChartData();
            }

        }

        private void GetChartData()
        {
            DataTable dt = Session["DoctorUserDetails"] as DataTable;
            int doctorID = int.Parse(dt.Rows[0]["DoctorID"].ToString());
            
        }
    }
}