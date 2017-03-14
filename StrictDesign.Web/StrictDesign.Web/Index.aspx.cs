using System;

namespace StrictDesign.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReadFile_Click(object sender, EventArgs e)
        {
            ReadFromFile ReadFile = new ReadFromFile();
            lblInfo.Text = ReadFile.GetContent();
        }

        protected void btnCheckNetwork_Click(object sender, EventArgs e)
        {

        }

        protected void btnSendMail_Click(object sender, EventArgs e)
        {
            try { 
                SendMail.MyMailMessage();
                lblSendMail.Text = "Mail sent!";
            }
            catch(System.Net.Mail.SmtpException ex)
            {
                lblSendMail.Text = ex.ToString();
            }


        }

        protected void btnConnectToDB_Click(object sender, EventArgs e)
        {

            object conn = new DatabaseConnection();
            

            //lblConn.Text = conn.ToString();
        }
    }
}