internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите Имя");
        string name = Console.ReadLine();
        Console.WriteLine("Введите символ");
        string symbol = Console.ReadLine();
        int sideSymbol = 2;

        for (int i = 0; i < name.Length + sideSymbol; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine($"\n{symbol}{name}{symbol}");

        for (int i = 0; i < name.Length + sideSymbol; i++)
        {
            Console.Write(symbol);
        }
    }
}