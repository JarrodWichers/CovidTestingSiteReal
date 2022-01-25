using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.Data;
using System.Windows.Forms;

namespace HWMS08.Nurse
{
    public partial class TableBodyTempratures : System.Web.UI.Page
    {
        BusinessLogic b = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.IsPostBack == true)
            {


            }
            else
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                DataTable dt = Session["NurseUserDetails"] as DataTable;
                int nurseID = int.Parse(dt.Rows[0]["UserID"].ToString());

                

                dgvSchedule.DataSource = b.SelectTestBookingByNurseID(nurseID,date);
                dgvSchedule.DataBind();

            }




        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            

            
        }

        protected void dgvBodyTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
