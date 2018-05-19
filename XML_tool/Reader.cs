using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_tool {
    class Reader {

        //Atributes Settings
        
        XmlReaderSettings settings = new XmlReaderSettings {DtdProcessing = DtdProcessing.Parse};
        int ElementCount = 0;
        string[] TagElements;
        XmlReader[] xmlReader = new XmlReader[2];
        public HashSet<string>[] xml = new HashSet<string>[2];

        public Reader(string[] path) {
            for (int i = 0; i < xmlReader.Length; i++) {
                this.xmlReader[i] = XmlReader.Create(path[i], this.settings);
                this.xml[i] = new HashSet<string>();
            }
        }

        public Reader() { }

      public void ReadXMLElements() {
            for (int i = 0; i < xmlReader.Length; i++) {
                while (this.xmlReader[i].Read()) {
                    if (xmlReader[i].NodeType == XmlNodeType.Element) {
                        xml[i].Add(xmlReader[i].Name);
                        ElementCount++;
                    }
                }
            }

            Console.WriteLine(xml[0].Count);
            Console.WriteLine(xml[1].Count);
            Console.WriteLine(ElementCount);
        }

    

    }
}
