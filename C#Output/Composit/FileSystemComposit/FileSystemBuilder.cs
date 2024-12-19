using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Output.Composit.FileSystemComposit
{
    public class FileSystemBuilder
    {
        private Directory root;
        private Directory currentDir    ;

        public Directory Root
        {
            get
            {
                return root;
            }
        }

        public FileSystemBuilder(string rootName)
        {
            this.root = new Directory(rootName);
            this.currentDir = this.root;
        }
        public  void AddDirectory(string name)
        {
            var dir = new Directory(name);
            currentDir.Add(dir);
            this.currentDir = dir;
   

        }
        public void AddFile(string name)
        {
            var file = new File(name);
            currentDir.Add(file);
               
        }

        public void SetCurrentDirectory(string name)
        {
            var dirs = new Stack<Directory>(); 
            dirs.Push(root);
            while (dirs.Any())
            {
                var currDir = dirs.Pop();
                if(currDir.Name == name)
                {
                    this.currentDir =  currDir;
                    return;
                }
                foreach (var dir in currDir.fileSystems.OfType<Directory>())
                {
                    dirs.Push(dir);
                }
            }
            throw new InvalidOperationException($"Dirctroy {name} not fould");

        }
    }
}
