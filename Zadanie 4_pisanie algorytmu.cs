using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wartość a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość c:");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość d:");
        int d = int.Parse(Console.ReadLine());

        int x, y;

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak ybd rozwiązania");
        }
        else
        {
            x = a + c;
            y = b + d;

            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }
    }
}

