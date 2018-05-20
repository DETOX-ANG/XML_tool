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
        XmlReader[] xmlReader = new XmlReader[2];
        public HashSet<string>[] xml = new HashSet<string>[2];

        //Construtor Com Parâmetro de Path para inicializar os arrays
        public Reader(string[] path) {
            for (int i = 0; i < xmlReader.Length; i++) {
                this.xmlReader[i] = XmlReader.Create(path[i], this.settings);
                this.xml[i] = new HashSet<string>();
            }
        }

        //Construtor Simples
        public Reader() { }

        //TODO Remover atividade "Add elementos no conjunto" do método de leitura, para não tirar o objetivo do método
      public HashSet<string>[] ReadXMLElements() {
            for (int i = 0; i < xmlReader.Length; i++) {
                while (this.xmlReader[i].Read()) {
                    if (xmlReader[i].NodeType == XmlNodeType.Element) {
                        xml[i].Add(xmlReader[i].Name);
                    }
                }
            }
            return xml;
      }

    

    }
}
