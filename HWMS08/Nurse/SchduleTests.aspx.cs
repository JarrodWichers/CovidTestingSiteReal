using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
namespace HWMS08.Nurse
{
    public partial class TableRespirationRates : System.Web.UI.Page
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
                DataTable dt = Session["NurseUserDetails"] as DataTable;
                int nurseID = int.Parse(dt.Rows[0]["UserID"].ToString());

                dgvTestToSchedule.DataSource = b.GetTestRequests();
                dgvTestToSchedule.DataBind();

                string date = DateTime.Now.ToString("yyyy-MM-dd");
                dgvSchedule.DataSource = b.SelectTestBookingByNurseID(nurseID,date);
                dgvSchedule.DataBind();

                ddlTimeSlot.Items.Clear();
               
                ddlTimeSlot.Items.Add("");
                ddlTimeSlot.Items.Add("6:00-8:00");
                ddlTimeSlot.Items.Add("8:00-10:00");
                ddlTimeSlot.Items.Add("10:00-12:00");
                ddlTimeSlot.Items.Add("12:00-14:00");
                ddlTimeSlot.Items.Add("14:00-16:00");
                ddlTimeSlot.Items.Add("16:00-18:00");
                ddlTimeSlot.Items.Add("18:00-20:00");

                lblDateValid.Visible = false;

            }
        }
       
     

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void dgvRespiration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            string date = txtBookingDate.Text;
            
            
                DataTable dt = Session["NurseUserDetails"] as DataTable;
                int nurseID = int.Parse(dt.Rows[0]["UserID"].ToString());
            string name = dt.Rows[0]["FullName"].ToString() + " " + dt.Rows[0]["Surname"].ToString();

                int requestID = int.Parse(Session["requestID"].ToString());

                int memberID = int.Parse(Session["memberID"].ToString());

                TestBooking book = new TestBooking();

                book.BookingDate = date;
                book.BookingTimeSlot = ddlTimeSlot.SelectedItem.Text.ToString();
                book.RequestID = requestID;
                book.NurseID = nurseID;

                b.InsertTestBooking(book);

                string date1 = DateTime.Now.ToString("yyyy-MM-dd");
                dgvSchedule.DataSource = b.SelectTestBookingByNurseID(nurseID,date1);
                dgvSchedule.DataBind();


                DataTable dt2 = b.GetMainMemberDetailsByID(memberID);
                string email = dt2.Rows[0]["EmailAddress"].ToString();

                MailMessage message = new MailMessage();
                message.From = new MailAddress("s219588880@mandela.ac.za", "Jarrod Wichers");
                message.Subject = "Test Booking";
                message.To.Add(email);
                message.Body = "Good Day \n"+"This is your Test booking on: " +date +"\n at " + ddlTimeSlot.SelectedValue + " with "+name+"\n  Kind Regards ";
                message.IsBodyHtml = true;
                message.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;

                smtp.Host = "smtp.live.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("s219588880@mandela.ac.za", "W1chersjt");
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;

                smtp.Send(message);
            

            

        }

        protected void dgvTestToSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            int requestID = int.Parse(dgvTestToSchedule.SelectedRow.Cells[1].Text);
            int memberID = int.Parse(dgvTestToSchedule.SelectedRow.Cells[5].Text);

            Session.Add("requestID", requestID);
            Session.Add("memberID", memberID);
        }

        protected void txtBookingDate_TextChanged(object sender, EventArgs e)
        {
            



            
            string date = txtBookingDate.Text;

            if (date == "2021-11-11")
            {
                lblDateValid.Visible = true;
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                lblDateValid.Visible = false;
            }
        }
    }
}

        
    