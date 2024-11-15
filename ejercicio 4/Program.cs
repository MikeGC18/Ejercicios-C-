using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Ingrese la cantidad inicial de la inversión: ");
        double saldo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tasa de interés anual (en %): ");
        double tasaInteres = Convert.ToDouble(Console.ReadLine()) / 100;

        for (int any = 1; any <= 10; any++)
        {
            saldo *= (1 + tasaInteres);
            Console.WriteLine($"Año {any}: Saldo = {saldo:C}");
        }
    }
}
