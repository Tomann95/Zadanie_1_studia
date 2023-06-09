using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wage w kilogramach");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wzrost w metrach");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);
        Console.WriteLine("Twój współczynnik BMI wynosi: " + bmi);
        Console.ReadKey();
    }
}
