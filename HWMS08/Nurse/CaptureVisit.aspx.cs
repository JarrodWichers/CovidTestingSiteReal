using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;
namespace HWMS08.Nurse
{
    public partial class TableHeartRates : System.Web.UI.Page
    {
        DataAccess dal = new DataAccess();
        BusinessLogic b = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == true)
            {


            }
            else
            {
                
                int mainID = int.Parse(Session["mainID"].ToString());

                

                ddlPatient.DataSource = b.GetDependentByMainID(mainID);
                ddlPatient.DataValueField = "UserID";
                ddlPatient.DataTextField = "FullName";
                ddlPatient.DataBind();


            }



        }
        
        //How i'm getting my average
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void dgvHeartData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            TestResult res = new TestResult();
            
            int patientID = int.Parse(Session["patientID"].ToString());
            int requestID = int.Parse(Session["requestID"].ToString());

            res.RequestID = requestID;
            res.PatientID = patientID;
            res.Temperature = double.Parse(txtTemp.Text);
            res.BloodPressure = txtBloodPressure.Text;
            res.OxygenLevels = int.Parse(txtOxygen.Text);

            b.InsertTestResults(res);

            Response.Redirect("./ChooseVisit.aspx");
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}