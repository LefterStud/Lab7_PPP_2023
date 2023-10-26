namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SparePart part1 = new SparePart("Wheel", 1, 500, 10);
            SparePart part2 = new SparePart("Wing", 2, 2000, 100);
            SparePart part3 = new SparePart("Engine", 3, 20000, 1000);
            Storage storage = new Storage();
            storage.AddPart(part1);
            storage.AddPart(part2);
            storage.AddPart(part3);
            Console.WriteLine(storage.FindPartById(1));
            foreach (SparePart part in storage.GetAllParts())
            {
                Console.WriteLine(part.ToString());
            }
        }
    }
}