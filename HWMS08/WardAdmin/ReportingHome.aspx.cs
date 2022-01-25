using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace HWMS08.WardAdmin
{
    public partial class ReportingHome : System.Web.UI.Page
    {
        BusinessLogic bll = new BusinessLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == true)
            {


            }
            else
            {

               



                ddlNurse.DataSource = bll.GetNurse();
                ddlNurse.DataValueField = "UserID";
                ddlNurse.DataTextField = "FullName";
                ddlNurse.DataBind();


            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        protected void btnSearchAdmissions_Click(object sender, EventArgs e)
        {
            string from = txtAdmitDateFrom.Text;
            string to = txtAdmitDateTo.Text;
            int nurseID = int.Parse(ddlNurse.SelectedValue.ToString());
            dgvAdmissions.DataSource = bll.ReportNurse(nurseID,from,to);
            dgvAdmissions.DataBind();
            dgvAdmissions.Visible = true;
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            ExportGridToPDF();
        }

        private void ExportGridToPDF()
        {

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Nurse_Report.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            dgvAdmissions.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
            dgvAdmissions.AllowPaging = true;
            dgvAdmissions.DataBind();
        }
    }
}