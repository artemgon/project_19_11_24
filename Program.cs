using project_19_11_24.Classes;

int length = int.Parse(Console.ReadLine() ?? "");
char symbol = char.Parse(Console.ReadLine() ?? "");

void PrintSquare(int length, char symbol)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
    for (int i = 0; i < length - 2; i++)
    {
        Console.Write(symbol);
        for (int j = 0; j < length - 2; j++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(symbol);
    }
    for (int i = 0; i < length; i++)
    {
        Console.Write(symbol);
    }
}

PrintSquare(length, symbol);