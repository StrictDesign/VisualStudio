using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StrictDesign.Web
{
    public partial class ReadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileContent = System.IO.File.ReadAllText(@"C:\Users\Jimmy\Source\Repos\VisualStudio\StrictDesign.Web\StrictDesign.Web\Text.txt");

            lblInfo.Text = fileContent;
        }

        protected void btnReadFile_Click(object sender, EventArgs e)
        {
            //ReadFromFile content = new ReadFromFile();
            //lblInfo.Text = fileCon
            
        }
    }
}