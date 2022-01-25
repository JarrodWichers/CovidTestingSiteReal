using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLogicLayer;
using DataAccessLayer;

namespace HWMS08.Doctor
{
    public partial class DoctorMedication : System.Web.UI.Page
    {
        BusinessLogic bll = new BusinessLogic();
        DataAccess dal = new DataAccess();
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == true)
            {
               

            }
            else
            {
                DataTable dt = Session["MainMemberUserDetails"] as DataTable;
                int mainID = int.Parse(dt.Rows[0]["UserID"].ToString());

                ddlSuburb.DataSource = bll.GetSuburb();
                ddlSuburb.DataValueField = "SuburbID";
                ddlSuburb.DataTextField = "SuburbName";
                ddlSuburb.DataBind();

                ddlSubject.DataSource = bll.GetDependentByMainID(mainID);
                ddlSubject.DataValueField = "DependentID";
                ddlSubject.DataTextField = "FullName";
                ddlSubject.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddDrug_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnRemoveDrug_Click(object sender, EventArgs e)
        {
            
        }

        protected void dgvPrescription_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void dgvPrescription_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
            
            

        }

        protected void btnAddPrescription_Click(object sender, EventArgs e)
        {
            

            
            
            

        }

        protected void txtSearchScript_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtMedication_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_click(object sender, EventArgs e)
        {
            
        }

        protected void btnAddDrug_Click1(object sender, EventArgs e)
        {
            

            
            
        }

        protected void dgvScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnDeleteDrug_Click(object sender, EventArgs e)
        {
            
            
            

            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = Session["MainMemberUserDetails"] as DataTable;
            int mainID = int.Parse(dt.Rows[0]["UserID"].ToString());

            int suburbID = int.Parse(ddlSuburb.SelectedValue.ToString());

            int subjectID = int.Parse(ddlSubject.SelectedValue.ToString());


            string date = txtRequestDate.Text;
            TestRequest test = new TestRequest();

            test.RequestorID = mainID;
            test.RequestDate = date;
            test.RequestTime = txtTime.Text;
            test.TestAdressLine1 = txtAddress1.Text;
            test.TestAdressLine2 = txtAddress2.Text;
            test.TestSubjectID = subjectID;
            test.TestSuburbID = suburbID;
            test.Status = "N";

            bll.InsertTestRequest(test);
        }

        protected void btnUpdateDrug_Click(object sender, EventArgs e)
        {
            
            

            

            

            
        }

        protected void btnEditDrug_Click(object sender, EventArgs e)
        {
            
        }

        protected void dgvMedication_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            
        }
    }
}