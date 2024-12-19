using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Output.Composit.BuiltInComposit
{
    public static class ExtenstionsFile
    {
        public static IEnumerable<XElement> FindAllFiles(this XElement rootElement, Predicate<XElement> isFile)
        {

            var stack = new Stack<XElement>();
            stack.Push(rootElement);
            while (stack.Any())
            {
                var topElement = stack.Pop();

                foreach(var xele in topElement.Elements())
                {
                  stack.Push(xele);   
                }

                if (isFile(topElement))
                {
                    yield return topElement;
                }

            }          
        }
    }
}
