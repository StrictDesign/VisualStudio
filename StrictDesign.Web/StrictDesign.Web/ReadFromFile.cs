using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrictDesign.Web
{
    class ReadFromFile
    {
        public string fileContent;

        public string getContent()
        {
            return fileContent = System.IO.File.ReadAllText(@"C:\Users\Jimmy\Source\Repos\VisualStudio\StrictDesign.Web\StrictDesign.Web\Text.txt");
        }
    }
}