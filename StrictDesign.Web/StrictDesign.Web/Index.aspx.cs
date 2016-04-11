using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            lblInfo.Text = ReadFile.getContent();
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
    }
}