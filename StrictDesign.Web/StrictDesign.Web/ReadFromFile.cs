using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrictDesign.Web
{
    public class ReadFromFile
    {
        string fileContent = System.IO.File.ReadAllText(@"C:\Users\Jimmy\Source\Repos\VisualStudio\StrictDesign.Web\StrictDesign.Web\Text.txt");
    }
}