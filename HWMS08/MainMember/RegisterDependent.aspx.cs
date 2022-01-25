using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessLayer;
using BusinessLogicLayer;

namespace HWMS08.Doctor
{
    public partial class DoctorDrugChart : System.Web.UI.Page
    {
        DataAccess dal = new DataAccess();
        BusinessLogic bll = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == true)
            {

            }
            else
            {
                ddlSuburb.DataSource = bll.GetSuburb();
                ddlSuburb.DataValueField = "SuburbID";
                ddlSuburb.DataTextField = "SuburbName";
                ddlSuburb.DataBind();

                ddlMedicalAid.DataSource = bll.GetMedicalAid();
                ddlMedicalAid.DataValueField = "MedicalAidID";
                ddlMedicalAid.DataTextField = "MedicalAidName";
                ddlMedicalAid.DataBind();

                ddlMedicalAid.Enabled = true;
                ddlMedicalAidPlan.Enabled = true;
                txtMedicalNum.Enabled = true;

                rdbMedical.SelectedValue = "1";

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = Session["MainMemberUserDetails"] as DataTable;
            int mainID = int.Parse(dt.Rows[0]["UserID"].ToString());


            if ((Page.IsValid) && (rdbMedical.SelectedValue == "1"))
            {

                int suburbID = int.Parse(ddlSuburb.SelectedValue.ToString());
                int medicalID = int.Parse(ddlMedicalAid.SelectedValue.ToString());
                int medicalPlanID = int.Parse(ddlMedicalAidPlan.SelectedValue.ToString());

                Dependent dep = new Dependent();

                dep.FullName = txtName.Text;
                dep.MainMemberID = mainID;
                dep.UserID = 1;
                dep.IDNumber = txtID.Text;
                dep.Surname = txtSurname.Text;
                dep.CellNumber = txtCell.Text;
                dep.EmailAddress = txtEmail.Text;
                dep.AddressLine1 = txtAddress1.Text;
                dep.AddressLine2 = txtAddress2.Text;
                dep.SuburbID = suburbID;
                dep.MedicalAid = "Y";
                dep.MedicalAidPlanID = medicalPlanID;
                dep.MedicalAidNumber = txtMedicalNum.Text;
                dep.ResponsiblePerson = txtResponsible.Text;

                bll.InsertDependant(dep);

            }
            else if ((Page.IsValid) && (rdbMedical.SelectedValue == "2"))
            {
                int suburbID = int.Parse(ddlSuburb.SelectedValue.ToString());

                Dependent dep = new Dependent();

                dep.FullName = txtName.Text;
                dep.MainMemberID = mainID;
                dep.UserID = 1;
                dep.IDNumber = txtID.Text;
                dep.Surname = txtSurname.Text;
                dep.CellNumber = txtCell.Text;
                dep.EmailAddress = txtEmail.Text;
                dep.AddressLine1 = txtAddress1.Text;
                dep.AddressLine2 = txtAddress2.Text;
                dep.SuburbID = suburbID;
                dep.MedicalAid = "N";
                dep.MedicalAidNumber = "";
                dep.ResponsiblePerson = txtResponsible.Text;

                bll.InsertDependant(dep);


            }


            }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlMedicalAid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int medicalID = int.Parse(ddlMedicalAid.SelectedValue.ToString());

            ddlMedicalAidPlan.DataSource = bll.GetMedicalPlanByMedicalID(medicalID);
            ddlMedicalAidPlan.DataValueField = "MedicalAidPlanID";
            ddlMedicalAidPlan.DataTextField = "MedicalAidPlanName";
            ddlMedicalAidPlan.DataBind();
        }

        protected void rdbMedical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbMedical.SelectedValue == "1")
            {
                ddlMedicalAid.Enabled = true;
                ddlMedicalAidPlan.Enabled = true;
                txtMedicalNum.Enabled = true;
            }
            else
            {
                ddlMedicalAid.Enabled = false;
                ddlMedicalAidPlan.Enabled = false;
                txtMedicalNum.Enabled = false;
            }
        }
    }
}