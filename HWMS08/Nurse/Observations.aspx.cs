using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Data;

namespace HWMS08
{
    public partial class NursesMonitor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("HH:mm");

            SqlConnection con = new SqlConnection("");
            SqlCommand cmd = new SqlCommand("", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(ds, "");
            ddlPatientID.DataSource = ds.Tables[0];
            ddlPatientID.SelectedValue = "";
            con.Close();

           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBloodPressure_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}