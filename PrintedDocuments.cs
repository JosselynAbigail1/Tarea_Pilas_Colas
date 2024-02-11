using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas_Colas
{
    public class PrintedDocuments
    {
        private Stack<string> printedStack;

        public PrintedDocuments()
        {
            printedStack = new Stack<string>();
        }

        public void PushDocument(string document)
        {
            printedStack.Push(document);
        }

        public string PopDocument()
        {
            if (printedStack.Count > 0)
            {
                return printedStack.Pop();
            }
            return null; // En caso de que la pila esté vacía
        }

        public bool IsEmpty()
        {
            return printedStack.Count == 0;
        }

        public string[] GetAllDocuments()
        {
            return printedStack.ToArray();
        }
    }
}