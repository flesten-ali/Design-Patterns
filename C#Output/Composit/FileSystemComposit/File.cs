using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Composit.FileSystemComposit
{
    public class File : FileSystem
    {
        public File(string name) : base(name)
        {
        }

        public override void PrimaryOperation()
        {
            Console.WriteLine($"File name is {Name}");
         }
    }
}
