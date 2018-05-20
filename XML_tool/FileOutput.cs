using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace XML_tool {
    class FileOutput {

        FileStream file = new FileStream("C:\\Users\\Public\\Documents\\Teste.txt", FileMode.OpenOrCreate);

        public FileOutput (Compare compare) {

            WriteFile(compare.GetCompareResults());
        }

        public FileOutput(HashSet<string> ProcResults) {
            //WriteFile(ProcResults);
        }
        
        public void WriteFile(string[] value) {
            StreamWriter writer = new StreamWriter(file);
            foreach (string item in value) {
                Console.WriteLine(item);
                writer.WriteLine(item);
            }
            
    
            writer.Flush();
            writer.Close();
            
            
        }
            

    }
}
