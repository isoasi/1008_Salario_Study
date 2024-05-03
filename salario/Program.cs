using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        int NUMBER, horaTrabalhada;

        double valorHora, totalSALARY;

        NUMBER = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        horaTrabalhada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        totalSALARY = valorHora * horaTrabalhada;

        Console.WriteLine("NUMBER = " + NUMBER);

        Console.WriteLine("SALARY = U$ " + totalSALARY.ToString("F2", CultureInfo.InvariantCulture));

        Console.Read();

    }

}