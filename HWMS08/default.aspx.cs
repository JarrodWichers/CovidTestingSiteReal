using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLogicLayer;

namespace HWMS08
{
    public partial class _default : System.Web.UI.Page
    {
        BusinessLogic bll = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();

            DataTable dt = bll.GetUserLogin(username, password);
            if (dt.Rows.Count > 0)
            {
                string role1 = dt.Rows[0]["UserType"].ToString();
                int userID = Convert.ToInt32(dt.Rows[0]["UserID"].ToString());

                DataTable dt1 = bll.GetLoginMainMember(userID);
                DataTable dt2 = bll.GetLoginNurse(userID);
                DataTable dt3 = bll.GetLoginManager(userID);
                if(dt1.Rows.Count > 0)
                {
                    Session.Add("MainMemberUserDetails", dt1);
                    Response.Redirect("./MainMember/RegisterDependent.aspx");
                }
                else if(dt2.Rows.Count > 0)
                {
                    Session.Add("NurseUserDetails", dt2);
                    Response.Redirect("./Nurse/ViewSchedule.aspx");
                }
                else if (dt3.Rows.Count > 0)
                {
                    Session.Add("ManagerDetails", dt3);
                    Response.Redirect("./WardAdmin/ReportingHome.aspx");
                }


                //if (role1 == "P")
                //{
                //    dt = bll.GetLoginMainMember(userID);
                //    Session.Add("MainMemberUserDetails", dt);
                //    // Add homepage for doctor
                //    Response.Redirect("./MainMember/RegisterDependent.aspx");
                //}
                //else if (role1 == "N")
                //{
                //    dt = bll.GetLoginNurse(userID);
                //    Session.Add("NurseUserDetails", dt);
                //    // Add homepage for nurse
                //    Response.Redirect("./Nurse/PersonalDetailsViews.aspx");
                //}
                //else if (role1 == "M")
                //{
                //    dt = bll.GetLoginManager(userID);
                //    Session.Add("ManagerDetails", dt);
                //    // Add homepage for nurse
                //    Response.Redirect("./Nurse/PersonalDetailsViews.aspx");
                //}
                //else
                //{
                //    txtUsername.Text = "User Not Found";
                //}

            }
            else
            {
                txtUsername.Text = "User Not Found 123";
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("./MainMember/MainMemberRegistration.aspx");
        }
    }
}