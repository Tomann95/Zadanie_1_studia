using System;
using Internal;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wartość x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość y:");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość r:");
        double r = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        if (distance <= r)
        {
            Console.WriteLine("Punkt P({0}, {1}) leży w obrębie koła o środku O(0, 0) i promieniu {2}", x, y, r);
        }
        else
        {
            Console.WriteLine("Punkt P({0}, {1}) nie leży w obrębie koła o środku O(0, 0) i promieniu {2}", x, y, r);
        }
    }
}


