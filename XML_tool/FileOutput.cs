using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace XML_tool {
    class FileOutput {
        
        
        

        public void WriteFile() {
            FileStream file = new FileStream("C:\\Users\\Public\\Documents\\Teste.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Angelo Rocha\n Angelo AAAA");
            writer.WriteLine("Angelo AAAA");
            writer.Flush();
            writer.Close();
            
            
        }
            

    }
}
