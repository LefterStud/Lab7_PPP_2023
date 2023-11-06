using System.Diagnostics;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SparePart part1 = new SparePart("Wheel", 500, 10);
            SparePart part2 = new SparePart("Wing", 2000, 100);
            SparePart part3 = new SparePart("Engine", 20000, 1000);
            SparePart part4 = new SparePart("Crankshaft", 3000, 5);
            Storage storage = new Storage();
            storage.AddPart(part1);
            storage.AddPart(part2);
            storage.AddPart(part3);
            storage.AddPart(part4);
            Console.WriteLine("All spare parts:");
            foreach (SparePart part in storage.GetAllParts())
            {
                Console.WriteLine(part.ToString());
            }
            Console.WriteLine("Find parts by Id and later Remove:");
            Console.WriteLine(storage.FindPartById(1));
            storage.RemovePart(storage.FindPartById(1));
            Console.WriteLine("All spare parts:");
            foreach (SparePart part in storage.GetAllParts())
            {
                Console.WriteLine(part.ToString());
            }
        }
    }
}