using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Podaj liczbe a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj liczbe b:");
        int b = Convert.ToInt32(Console.ReadLine());

        int wiekszaliczba = a > b ? a : b;

        Console.WriteLine("Wieksza liczba to:" + wiekszaliczba);
        Console.ReadKey();


    }
}

