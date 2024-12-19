using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Composit.FileSystemComposit
{
    public abstract class FileSystem
    {
        public string Name { get; }
        public FileSystem(string name) { Name = name; }

        public abstract void PrimaryOperation(); 
    }
}
