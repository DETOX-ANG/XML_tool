using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_tool
{
    class Compare {
        Reader results = new Reader();

        public HashSet<string>[] data;
        //public string[] CompareResult() {


        //}

        public Compare(Reader results) {
            data = results.ReadXMLElements();
            data[1].ExceptWith(data[0]);
            foreach (string item in data[1]) {
                Console.WriteLine(item);
            }
        }

        public string[] GetCompareResults() {
            return data[1].ToArray();
        }


    }
}
