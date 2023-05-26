namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Hello World");
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);

            System.Console.WriteLine(chest);
        }
    }
}
