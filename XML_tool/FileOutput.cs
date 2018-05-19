using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace XML_tool {
    class FileOutput {

        FileStream file = new FileStream("C:\\Users\\Public\\Documents\\Teste.txt", FileMode.OpenOrCreate);

        public FileOutput(HashSet<string> ProcResults) {
            WriteFile(ProcResults);
        }
        
        public void WriteFile(HashSet<string> tags) {
            StreamWriter writer = new StreamWriter(file);

            foreach (string item in tags) {
                Console.WriteLine(item);
                writer.WriteLine(item);
            }
            
    
            writer.Flush();
            writer.Close();
            
            
        }
            

    }
}
