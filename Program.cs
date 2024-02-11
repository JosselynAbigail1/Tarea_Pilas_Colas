using Tarea_Pilas_Colas;
class Program
{
    static void Main(string[] args)
    {
        string[] documents = { "DocPOO", "Analisis", "Doc1", "Colores" };
                DocumentPrinter printer = new DocumentPrinter();
        printer.PrintDocuments(documents);
        Console.WriteLine("\n------Archivos Impresos------");
        foreach (string printedDocument in printer.PrintedDocuments)
        {
            Console.WriteLine(printedDocument);
        }
    }
}
