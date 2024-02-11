using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilas_Colas
{

    public class PrintQueue
    {
        private Queue<string> pendingQueue;

        public PrintQueue()
        {
            pendingQueue = new Queue<string>();
        }

        public void EnqueueDocument(string document)
        {
            pendingQueue.Enqueue(document);
        }

        public string DequeueDocument()
        {
            if (pendingQueue.Count > 0)
            {
                return pendingQueue.Dequeue();
            }
            return null; // En caso de que la cola esté vacía
        }

        public bool IsEmpty()
        {
            return pendingQueue.Count == 0;
        }

        public string[] GetAllDocuments()
        {
            return pendingQueue.ToArray();
        }
    }
}
