using System;

namespace ahorcado
{
    class Program
{
static void Main(string[] args)
{

String opcion;
String continuar;
            do
            {
                Console.WriteLine("-----Figuras geométricas-----------------");
                Console.WriteLine("|                                       |");
                Console.WriteLine("|    1.-  Circulo                       |");
                Console.WriteLine("|    2.-  Triangulo                     |");
                Console.WriteLine("|    3.-  Rectangulo                    |");
                Console.WriteLine("|    4.-  Cuadrado                      |");
                Console.WriteLine("|    5.-  Rombo                         |");
                Console.WriteLine("|    6.-  Paralelogramo                 |");
                Console.WriteLine("|    7.-  Trapecio                      |");
                Console.WriteLine("|    8.-  Pentagono                     |");
                Console.WriteLine("|    9.-  Hexagono                      |");
                Console.WriteLine("|    10.- Salir                         |");
                Console.WriteLine("|                                       |");
                Console.WriteLine("------------------VaidrollTeam-----------");
                Console.Write("Dime una opción: ");
                opcion = Console.ReadLine();
                Console.WriteLine("-----------------------------");
                switch (opcion)
                {
                    case "1":
                        {    int x;
    int y;
    int radio;
    Console.Write("Ingresar el radio del circulo: ");
    radio = int.Parse(Console.ReadLine());
    for (x = 0; x <= radio * 2; x++) //Altura
    {
        for (y = 0; y <= radio * 2; y++) //Rellenar
        {
            //Ecuacion circunferencia
            //((X-h)^2) + ((y-k)^2) = radio^2 
            if (Math.Pow(y - radio, 2) + Math.Pow(x - radio, 2) <= (int)Math.Pow(radio, 2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine(" ");

    } }
                   
                        break;
                    case "2":
                        { 
//-----------------------------------------------------------------
    //Altura Triangulo (3 lados)
    int x, y, altura;
    Console.Write("Ingresar la altura del triangulo: ");
    altura = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");

    for (x = 1; x <= altura; x++)
    {
        for (y = altura - x; y > 0; y--)
        {
            Console.Write(" ");
        }
        for (y = 1; y < x; y++)
        {
            Console.Write("**");
        }
        Console.WriteLine("*");
    }
//-----------------------------------------------------------------
}

                        break;
                    case "3":
                        { //-----------------------------------------------------------------
    //Rectangulo (4 lados)
    int base1, altura, x, y;
    Console.Write("Ingresar la base del rectangulo: ");
    base1 = int.Parse(Console.ReadLine());
    Console.Write("Ingresar la altura del rectangulo: ");
    altura = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");

    for (x = 1; x <= altura; x++)
    {
        for (y = 1; y <= base1; y++)
        {
            Console.Write("* ", y);
        }
        Console.WriteLine(" ");
    }
//-----------------------------------------------------------------
}
                        break;
                    case "4":
                        { 
                            //Cuadrado (4 lados)
    int lado, x, y;
    Console.Write("Ingresar el lado del cuadrado: ");
    lado = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    for (x = 1; x <= lado; x++)
    {
        for (y = 1; y <= lado; y++)
        {
            Console.Write("* ");
        }
        Console.WriteLine(" ");
    }
    }
                        break;
                    case "5":
                        {
int x, y, lado;
    Console.Write("Ingresar el lado del rombo: ");
    lado = int.Parse(Console.ReadLine());

    for (x = 0; x <= lado; x++)
    {
        for (y = lado - x; y > 0; y--)
        {
            Console.Write(" ");
        }
        for (y = 0; y < x; y++)
        {
            Console.Write(" *");

        }
        Console.WriteLine(" ");
    }

    for (x = 0; x <= lado; x++)
    {
        for (y = 0; y <= x; y++)
        {
            Console.Write(" ");
        }
        for (y = lado - x - 1; y > 0; y--)
        {
            Console.Write(" *");

        }
        Console.WriteLine(" ");
    }

                         }
                        break;
                    case "6":
                        { 
    int base1, altura, x, y;
    Console.Write("Ingresar la base del Paralelogramo: ");
    base1 = int.Parse(Console.ReadLine());
    Console.Write("Ingresar la altura del Paralelogramo: ");
    altura = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");

    for (x = 1; x <= altura; x++)
    {
        for (y = altura - x; y > 0; y--)
        {
            Console.Write(" ");
        }
        for (y = 0; y < base1; y++)
        {
            Console.Write(" *");
        }
        Console.WriteLine(" ");
    }
                        }
                        break;
                    case "7":
                        { 
   int base1, altura, x, y, z, aux;
    Console.Write("Ingresar la base superior del trapecio: ");
    base1 = int.Parse(Console.ReadLine());
    Console.Write("Ingresar la altura del trapecio: ");
    altura = int.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    aux = altura;
    for (x = 1; x <= altura; x++)
    {

        for (y = aux; y > 1; y--)
        {
            Console.Write("  ");
        }

        for (z = 0; z < base1; z++)
        {
            Console.Write("*");
        }

        Console.WriteLine(" ");

        base1 = base1 + 4;
        aux--;
    }
                        }
                        break;
                    case "8":
                        { 
     int base1, x, y;
    Console.Write("Ingresar la base del pentagono: ");
    base1 = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");

    for (x = 1; x <= base1; x++)
    {
        for (y = base1 - x; y > 0; y--)
        {
            Console.Write(" ");
        }
        for (y = 1; y < x; y++)
        {
            Console.Write(" *");
        }
        Console.WriteLine(" ");
    }

    for (x = 1; x <= base1; x++)
    {
        for (y = 1; y <= base1; y++)
        {
            Console.Write("* ");
        }
        Console.WriteLine(" ");
    }
                        }
                        break;
                    case "9":
                        { 

    //Hexagono (6 lados)
    int x, y, base1;

    Console.Write("Ingresar la base del hexagono: ");
    base1 = int.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    for (x = 0; x < base1 - 1; x++)
    {
        Console.Write(" ");
    }
    for (x = 0; x < base1; x++)
    {
        Console.Write("*");
    }

    for (y = 1; y < base1 - 1; y++)
    {
        Console.WriteLine(" ");
        for (x = 0; x < base1 - y - 1; x++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        for (x = 0; x < base1 + 2 * y - 2; x++)
        {
            Console.Write("*");
        }
        Console.Write("*");
    }

    for (y = base1; y > 1; y--)
    {
        Console.WriteLine(" ");
        for (x = 0; x < base1 - y; x++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        for (x = 0; x < base1 + 2 * y - 4; x++)
        {
            Console.Write("*");
        }
        Console.Write("*");
    }

    Console.WriteLine(" ");
    for (x = 0; x < base1 - 1; x++)
    {
        Console.Write(" ");
    }
    for (x = 0; x < base1; x++)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");
                        }
                        break;
                    case "10":
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("-------------------------------");
                Console.Write("¿Deseas continuar? y/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Clear();
            }
            while (continuar != "n");

            Console.WriteLine("Adiós");
            Console.ReadKey();



}
}
}
