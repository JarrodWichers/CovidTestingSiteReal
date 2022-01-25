using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Text.RegularExpressions;

namespace HWMS08.Doctor
{
    public partial class DoctorPatientDetails : System.Web.UI.Page
    {
        DataAccess dal = new DataAccess();
        BusinessLogic bll = new BusinessLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

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
                ddlMedicalPlan.Enabled = true;

                rdbMedical.SelectedValue = "1";
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
                
            if ((Page.IsValid)&& (rdbMedical.SelectedValue == "1"))
            {
                int suburbID = int.Parse(ddlSuburb.SelectedValue.ToString());
                int medicalID = int.Parse(ddlMedicalAid.SelectedValue.ToString());
                int medicalPlanID = int.Parse(ddlMedicalPlan.SelectedValue.ToString());

                User use = new User();

                use.Username = txtEmail.Text;
                use.Password = txtPassword.Text;
                use.Status = "A";
                use.UserType = "P";

                bll.InsertUser(use);

                string username = txtEmail.Text.ToString();
                string password = txtPassword.Text.ToString();

                DataTable dt = bll.GetUserLogin(username, password);

                int userID = Convert.ToInt32(dt.Rows[0]["UserID"].ToString());

                MainMember main = new MainMember();

                main.UserID = userID;
                main.IDNumber = txtID.Text;
                main.FullName = txtName.Text;
                main.Surname = txtSurname.Text;
                main.MedicalAid = "Y";
                main.MedicalAidNumber = txtMedicalNum.Text;
                main.MedicalAidPlanID = medicalPlanID;
                main.CellNumber = txtCellNum.Text;
                main.AddressLine1 = txtAddress1.Text;
                main.AddressLine2 = txtAddress2.Text;
                main.EmailAddress = txtEmail.Text;
                main.SuburbID = suburbID;
                main.ResponsiblePerson = txtResponsiblePerson.Text;

                bll.InsertMainMember(main);

                Dependent dep = new Dependent();

                dep.FullName = txtName.Text;
                dep.MainMemberID = userID;
                dep.UserID = 1;
                dep.IDNumber = txtID.Text;
                dep.Surname = txtSurname.Text;
                dep.CellNumber = txtCellNum.Text;
                dep.EmailAddress = txtEmail.Text;
                dep.AddressLine1 = txtAddress1.Text;
                dep.AddressLine2 = txtAddress2.Text;
                dep.SuburbID = suburbID;
                dep.MedicalAid = "Y";
                dep.MedicalAidPlanID = medicalPlanID;
                dep.MedicalAidNumber = txtMedicalNum.Text;
                dep.ResponsiblePerson = txtResponsiblePerson.Text;

                bll.InsertDependant(dep);

                Response.Redirect("../default.aspx");

                
            }
            else if ((Page.IsValid) && (rdbMedical.SelectedValue == "2"))
            {
                int suburbID = int.Parse(ddlSuburb.SelectedValue.ToString());

                User use = new User();

                use.Username = txtEmail.Text;
                use.Password = txtPassword.Text;
                use.Status = "A";
                use.UserType = "P";

                bll.InsertUser(use);

                string username = txtEmail.Text.ToString();
                string password = txtPassword.Text.ToString();

                DataTable dt = bll.GetUserLogin(username, password);

                int userID = Convert.ToInt32(dt.Rows[0]["UserID"].ToString());

                MainMember main = new MainMember();

                main.UserID = userID;
                main.IDNumber = txtID.Text;
                main.FullName = txtName.Text;
                main.Surname = txtSurname.Text;
                main.MedicalAid = "N";
                main.MedicalAidNumber = "";
                
                main.CellNumber = txtCellNum.Text;
                main.AddressLine1 = txtAddress1.Text;
                main.AddressLine2 = txtAddress2.Text;
                main.EmailAddress = txtEmail.Text;
                main.SuburbID = suburbID;
                main.ResponsiblePerson = txtResponsiblePerson.Text;

                bll.InsertMainMember(main);

                Dependent dep = new Dependent();

                dep.FullName = txtName.Text;
                dep.MainMemberID = userID;
                dep.UserID = 1;
                dep.IDNumber = txtID.Text;
                dep.Surname = txtSurname.Text;
                dep.CellNumber = txtCellNum.Text;
                dep.EmailAddress = txtEmail.Text;
                dep.AddressLine1 = txtAddress1.Text;
                dep.AddressLine2 = txtAddress2.Text;
                dep.SuburbID = suburbID;
                dep.MedicalAid = "N";
                dep.MedicalAidNumber = "";
                dep.ResponsiblePerson = txtResponsiblePerson.Text;

                bll.InsertDependant(dep);

                Response.Redirect("../default.aspx");
            }
            else
            {
                
            }

            
        }

        protected void ddlMedicalAid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int medicalID = int.Parse(ddlMedicalAid.SelectedValue.ToString());

            ddlMedicalPlan.DataSource = bll.GetMedicalPlanByMedicalID(medicalID);
            ddlMedicalPlan.DataValueField = "MedicalAidPlanID";
            ddlMedicalPlan.DataTextField = "MedicalAidPlanName";
            ddlMedicalPlan.DataBind();
        }

        protected void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            ddlMedicalAid.Enabled = false;
            ddlMedicalPlan.Enabled = false;
        }

        protected void rdbYes_CheckedChanged(object sender, EventArgs e)
        {
            ddlMedicalAid.Enabled = true;
            ddlMedicalPlan.Enabled = true;
        }

        protected void rdbMedical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdbMedical.SelectedValue == "1")
            {
                ddlMedicalAid.Enabled = true;
                ddlMedicalPlan.Enabled = true;
            }
            else
            {
                ddlMedicalAid.Enabled = false;
                ddlMedicalPlan.Enabled = false;
            }
        }
    }
}