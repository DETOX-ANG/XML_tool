using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_tool {
    class XmlProcessing {

        HashSet<string> xml1 = new HashSet<string>();
        HashSet<string> xml2 = new HashSet<string>();
        string path = "C:\\Users\\Public\\Documents\\310.xml";
        XmlReaderSettings settings = new XmlReaderSettings {
            DtdProcessing = DtdProcessing.Parse
        };

        public void DisplayGroupDetails() {

            Console.WriteLine(xml1.Count);
            foreach (string element in xml1) {
                Console.WriteLine(element);
            }
        }

        public void ReadXMLElements() {
            XmlReader reader = XmlReader.Create(this.path, this.settings);
            while (reader.Read()) {
                if (reader.NodeType == XmlNodeType.Element) {
                    //Console.WriteLine(reader.Name);
                    AddTagsToGroup(reader.Name);
                }
            }

        }

        public void AddTagsToGroup(string TagName) {
            //Reader reader = new Reader("C:\\Users\\Public\\Documents\\310.xml");
            this.xml1.Add(TagName);
        }
    }
}
