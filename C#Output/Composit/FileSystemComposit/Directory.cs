using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Composit.FileSystemComposit
{
    public class Directory : FileSystem
    {
       public List<FileSystem> fileSystems  =  new List<FileSystem>();
        public Directory(string name) : base(name)
        {
        }

        public void Add(FileSystem fileSystem)
        {
            fileSystems.Add(fileSystem);
        }
        public void Remove(FileSystem fileSystem)
        {
            fileSystems.Remove(fileSystem);
        }
        public override void PrimaryOperation()
        {
            Console.WriteLine($"Folder Name {Name}");
            foreach (FileSystem fs in fileSystems)
            {
                fs.PrimaryOperation();
            }
           
            
        }
    }
}
