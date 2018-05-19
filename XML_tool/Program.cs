using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XML_tool
{
    class Program {
        static void Main(string[] args) {


        string[] path = new string[2] { "C:\\Users\\Public\\Documents\\310.xml", "C:\\Users\\Public\\Documents\\n40.xml "};
        Reader reader = new Reader(path);
        reader.ReadXMLElements();
            //XmlProcessing xmlProcessing = new XmlProcessing();
            //xmlProcessing.AddTagsToGroup(xmlreader.Name);
            //xmlProcessing.DisplayGroupDetails();
            //FileOutput fileOutput = new FileOutput(xmlProcessing.xml1);

            Console.ReadKey();
         }
}
}