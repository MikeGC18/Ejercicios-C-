using System;

class Program
{
    static void Main()
    {
        while (true)
        {
    
            Console.Write("Ingrese el primer número (o 1 para finalizar): ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == 1)
            {
                Console.WriteLine("Programa finalizado.");
                break;
            }

            Console.Write("Ingrese el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer número es mayor que el segundo.");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("El primer número es menor que el segundo.");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
    }
}
