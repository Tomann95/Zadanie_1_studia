using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj długość pierwszego boku: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość drugiego boku: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj długość trzeciego boku: ");
        double c = Convert.ToDouble(Console.ReadLine());

        bool TrojkatRownoboczny = a == b && b == c;

        if (TrojkatRownoboczny)
        {
            Console.WriteLine("Podane boki tworzą trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie tworzą trójkąta równobocznego.");
        }
        Console.ReadKey();
    }
}


