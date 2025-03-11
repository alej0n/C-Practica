using System;

namespace DocApp
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("The document is opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Redaction requieres the pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Save requieres the pro version");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document is redacted");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in the old version, save in other format requieres Expert version");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in new format");
        }
    }

    class Program
    {
        static void Main()
        {
            const string proKey = "pro123";
            const string expKey = "exp123";

            Console.Write("Typ key version: ");
            string userKey = Console.ReadLine();

            DocumentWorker worker;

            if (userKey == expKey)
            {
                worker = new ExpertDocumentWorker();
            }
            else if (userKey == proKey)
            {
                worker = new ProDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}
