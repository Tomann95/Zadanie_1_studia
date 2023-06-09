using System;
using Internal;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj numer działania (1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie):");
        int numerDzialania = int.Parse(Console.ReadLine());

        double wynik = 0;

        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 != 0)
                    wynik = liczba1 / liczba2;
                else
                    Console.WriteLine("Dzielenie przez zero! Wynik: {0}/0", liczba1);
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania!");
                break;
        }

        if (numerDzialania >= 1 && numerDzialania <= 4)
        {
            Console.WriteLine("Wynik: {0}", wynik);
        }
    }
}
