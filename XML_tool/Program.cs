using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XML_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlProcessing xmlProcessing = new XmlProcessing();
            xmlProcessing.ReadXMLElements();
            //xmlProcessing.DisplayGroupDetails();
            FileOutput fileOutput = new FileOutput(xmlProcessing.xml1);
            
            Console.ReadKey();
        }
    }
}
