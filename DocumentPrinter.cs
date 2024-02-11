using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas_Colas
{
    using System;
    using System.Collections.Generic;

    public class DocumentPrinter
    {
        private PrintQueue printQueue;
        private PrintedDocuments printedDocuments;

        public DocumentPrinter()
        {
            printQueue = new PrintQueue();
            printedDocuments = new PrintedDocuments();
        }

        public void PrintDocuments(string[] documents)
        {
            foreach (var document in documents)
            {
                printQueue.EnqueueDocument(document);
            }

            while (!printQueue.IsEmpty())
            {
                string currentDocument = printQueue.DequeueDocument();
                Console.WriteLine("Imprimiendo: " + currentDocument);
                printedDocuments.PushDocument(currentDocument);
            }
        }

        public IEnumerable<string> PrintedDocuments
        {
            get { return printedDocuments.GetAllDocuments(); }
        }
    }
}
