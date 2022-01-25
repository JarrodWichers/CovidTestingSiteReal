using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;

namespace HWMS08.Nurse
{
    public partial class ChooseVisit : System.Web.UI.Page
    {
        DataAccess dal = new DataAccess();
        BusinessLogic b = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            DataTable dt = Session["NurseUserDetails"] as DataTable;
            int nurseID = int.Parse(dt.Rows[0]["UserID"].ToString());

            dgvSelection.DataSource = b.SelectTestBookingByNurseID(nurseID,date);
            dgvSelection.DataBind();

            
        }

        protected void dgvSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int requestID = int.Parse(dgvSelection.SelectedRow.Cells[2].Text);

            DataTable dt2 = b.GetTestRequestsByRequestID(requestID);
            int mainID = int.Parse(dt2.Rows[0]["RequestorID"].ToString());
            int patientID = int.Parse(dt2.Rows[0]["TestSubjectID"].ToString());
            

            Session.Add("mainID", mainID);
            Session.Add("patientID", patientID);
            Session.Add("requestID", requestID);

            Response.Redirect("./CaptureVisit.aspx");
        }
    }
}