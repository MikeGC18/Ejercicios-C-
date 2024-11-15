

class Program
{
    static void Main()
    {
        int numero;

        do
        {
           
            Console.Write("Ingrese un número ");
            numero = Convert.ToInt32(Console.ReadLine());

           if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
        }
        while (numero != 0);

        Console.WriteLine("Programa finalizado.");
    }
}

