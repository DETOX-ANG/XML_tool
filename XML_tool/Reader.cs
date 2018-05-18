using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_tool
{
    class Reader
    {
        HashSet<string>[] XmlFile;
        
        
        

        public Reader(string path) {

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(path, settings);
            
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.None:
                        break;
                    case XmlNodeType.Element:
                        Console.WriteLine(reader.Name);
                        break;
                    default:
                        break;
                }
                
                
            }
        }



    }
}
