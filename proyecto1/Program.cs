using System;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creando la instancia Random
            Random aleatoreo = new Random();
            // creando la primer array
            int[] Array1= new int[20];
            // cargando el array
            for(int i = 0; i < Array1.Length; i++)
            {
                Array1[i]= aleatoreo.Next(1,50);
                Console.WriteLine("Pos N° "+i+" Vector: "+ Array1[i]);
            }

            Console.ReadKey();

        }
    }
}
