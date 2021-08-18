using System;

namespace ProblemaInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int numAleatorio  = random.Next(0, 100);
            Console.WriteLine("Escribe un numero");
            int numElegido = Convert.ToInt32(Console.ReadLine());

            do
            { 
                if (numElegido > numAleatorio)
                {
                    Console.WriteLine("El numero es mas chico");
                    numElegido = Convert.ToInt32(Console.ReadLine());
                }
               else
                {
                    Console.WriteLine("El numero es mas grande");
                    numElegido = Convert.ToInt32(Console.ReadLine());
                }

            } while (numElegido != numAleatorio);

            if (numElegido == numAleatorio)
            {
                Console.WriteLine("El numero es correcto");
            }
        }
    }
}
