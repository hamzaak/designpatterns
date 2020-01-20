using System;

namespace templatemethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Document htmlDocument = new HTMLDocument();
            Document XMLDocument = new XMLDocument();

            htmlDocument.Print();
            XMLDocument.Print();

            Console.ReadKey();
        }
    }

    public abstract class Document
    {
        public void Print()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public abstract void PrintHeader();
        public abstract void PrintBody();
        public abstract void PrintFooter();
    }

    public class HTMLDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("HTML - Header");
        }
        public override void PrintBody()
        {
            Console.WriteLine("HTML - Body");
        }
        public override void PrintFooter()
        {
            Console.WriteLine("HTML - Footer");
        }
    }

    public class XMLDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("XML - Header");
        }
        public override void PrintBody()
        {
            Console.WriteLine("XML - Body");
        }
        public override void PrintFooter()
        {
            Console.WriteLine("XML - Footer");
        }
    }
}
