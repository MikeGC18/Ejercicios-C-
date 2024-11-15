

using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Ingrese cuánto ahorra mensualmente: ");
        double ahorroMensual = Convert.ToDouble(Console.ReadLine());

       
        double totalAhorrado = 0;

      
        for (int mes = 1; mes <= 12; mes++)
        {
            totalAhorrado += ahorroMensual;
        }

       
        Console.WriteLine("El total ahorrado en un año es: " + totalAhorrado);
    }
}

