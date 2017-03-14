namespace StrictDesign.Web
{
    internal class ReadFromFile
    {
        public string FileContent;

        public string GetContent()
        {
            return FileContent = System.IO.File.ReadAllText(@"C:\Users\Jimmy\Source\Repos\VisualStudio\StrictDesign.Web\StrictDesign.Web\Text.txt");
        }
    }
}