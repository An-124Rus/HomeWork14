internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите Имя");
        string name = Console.ReadLine();
        Console.WriteLine("Введите символ");
        string symbol = Console.ReadLine();
        int sideSymbol = 2;
        string symbolLine = string.Empty;

        for (int i = 0; i < name.Length + sideSymbol; i++)
        {
            symbolLine += symbol;
        }

        Console.WriteLine(symbolLine);
        Console.WriteLine($"{symbol}{name}{symbol}");
        Console.WriteLine(symbolLine);        
    }
}