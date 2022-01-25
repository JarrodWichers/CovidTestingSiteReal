using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccessLayer;
using BusinessLogicLayer;
namespace HWMS08.Nurse
{
    public partial class OBSERVATION : System.Web.UI.Page
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

                

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int suburbID = int.Parse(ddlSuburb.SelectedValue.ToString());

            DataTable dt = Session["NurseUserDetails"] as DataTable;
            int nurseID = int.Parse(dt.Rows[0]["UserID"].ToString());

            NurseFavSub sub = new NurseFavSub();

            sub.NurseID = nurseID;
            sub.SuburbID = suburbID;

            bll.InsertNurseFavSuburb(sub);
        }
    }
}