using System;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1= new int[20];
            int[] Array2= new int[20];
            int[] Array3= new int[20];
            int max=Array1[0];
            int cont=0;
            int men=99;
            int cont2=0;
                    
                    Opciones();
                 
                    Console.Write("Seleccionar la opcion: ");
                    String s1=null;
                    s1=Console.ReadLine(); 

                            // creando la instancia Random
                            Random aleatoreo = new Random();
                            // cargando el array
                            Console.WriteLine("\n***********************************************");
                            for(int i = 0; i < Array1.Length; i++)
                            {
                            Array1[i]= aleatoreo.Next(1,50);
                            Console.WriteLine("Pos N° "+(i+1)+" Vector: "+ Array1[i]);
                            }
                            Console.WriteLine("\n***********************************************");
                   
                    switch(s1)
                    {
                        case "1":
                        Console.WriteLine("\n1. -Valor Maximo, en caso de estar repetido mostrar posición");
                            // maximo

                            
                            for(int j = 0; j < Array1.Length; j++)
                            {
                            if (Array1[j]>max)
                            {
                            max= Array1[j];
                            cont=j+1;
                            }
                            }
                            Console.WriteLine("\nPos N° "+cont+" Maximo: "+ max);
                        break;
                        case "2":
                        Console.WriteLine("\n2. -indicar el rango de los array, el valor minimo y maximo");
                            for(int j = 0; j < Array1.Length; j++)
                            {
                            if (Array1[j]>max)
                            {
                            max= Array1[j];
                            cont=j+1;
                            }
                            if (Array1[j]<men)
                            {
                            men= Array1[j];
                            cont2=j+1;
                            }
                            }
                            Console.WriteLine("\nPos N° "+cont+" Maximo: "+ max);
                            Console.WriteLine("\nPos N° "+cont2+" Minimo: "+ men);
                        break;
                        case "3":
                        Console.WriteLine("\n3. -Invertir el array");
                          // cargando el array
                       Array.Reverse(Array1);
                            Console.WriteLine("\n***********************************************");
                            for(int i = 0; i < Array1.Length; i++)
                            {
                            
                            Console.WriteLine("Pos N° "+(i+1)+" Vector: "+ Array1[i]);
                            }
                            Console.WriteLine("\n***********************************************");
                   
                        break;
                        case "4":
                        Console.WriteLine("\n4. -Mostrar hstograma");
                                                    // cargando el array
                            Console.WriteLine("\n***********************************************");
                            for(int i = 0; i < Array1.Length; i++)
                            {
                            Console.Write("\nPos N° "+(i+1)+" Vector: "+ Array1[i]+" ");
                                for(int t = 0; t < Array1[i]; t++)
                                {
                                Console.Write("#");
                                }
                            }
                            Console.WriteLine("\n***********************************************");
                        break;
                        case "5":
                        Console.WriteLine("\n5. -Mostrar un numero y rotar esa cantidad de posiciones el array");
                        
                       
                        break;
                        case "6":
                        Console.WriteLine("\n6. -Mostrar el valor que se repite mas veces y mostrarlo");
                        // cargando el array
                            Console.WriteLine("\n***********************************************");
                            bool repetidos=false;
                            for(int x = 0; x < Array1.Length; x++)
                            {
                            int a= Array1[x];
                            int c=x+1;
                            
                            for(int y=c;y<Array1.Length;y++)
                            {
                                int b=Array1[y];
                                if(a==b)
                                {
                                    repetidos=true;
                                     Console.WriteLine("\nEl N° "+ a + " Vesta repetido en la lista");

                                }

                            }
                           
                            }
                            if(repetidos==false)
                            {
                                 Console.WriteLine("\nNo existe numeros repetidos");
                            }
                            Console.WriteLine("\n***********************************************");
                        break;
                        case "7":
                        Console.WriteLine("\n7. -Generar un nuevo array y ordenarlo en forma creciente");
                        // creando la instancia Random
                            Random aleatoreo2 = new Random();
                            // cargando el array
                            Console.WriteLine("\n***********************************************");
                            for(int i = 0; i < Array2.Length; i++)
                            {
                            Array2[i]= aleatoreo2.Next(1,50);
                            Console.WriteLine("Pos N° "+(i+1)+" Vector: "+ Array2[i]);
                            }
                            Console.WriteLine("\n***********************************************");
                            //  Ordenar
                            for (int p=Array2.Length - 1 ; p>=0;p--)
                            {
                                int pmax=0;
                                int vmax=Array2[0];
                                for (int r=0 ; r<=p;r++)
                                    {
                                        if(Array2[r]>vmax)
                                        {
                                            vmax=Array2[r];
                                            pmax=r;
                                        }
                                        
                                    }
                                    int aux=Array2[p];
                                    Array2[p]=Array2[pmax];
                                    Array2[pmax]=aux;
                            }
                            Console.WriteLine("\n*******************ORDENAR********************");
                            for(int i = 0; i < Array2.Length; i++)
                            {
                       
                            Console.WriteLine("Pos N° "+(i+1)+" Vector: "+ Array2[i]);
                            }
                            Console.WriteLine("\n***********************************************");
                        break;
                        case "8":
                        Console.WriteLine("\n8. -Salir");
                        break;

                    }
      

            Console.ReadKey();

        }
        public static void Opciones()
        {
                    //menu
                    Console.WriteLine("Elige una opcion:\n"+
                    "\n1. -Valor Maximo, en caso de estar repetido mostrar posición"+
                    "\n2. -indicar el rango de los array, el valor minimo y maximo"+
                    "\n3. -Invertir el array"+
                    "\n4. -Mostrar hstograma"+
                    "\n5. -Mostrar un numero y rotar esa cantidad de posiciones el array"+
                    "\n6. -Mostrar el valor que se repite mas veces y mostrarlo"+
                    "\n7. -Generar un nuevo array y ordenarlo en forma creciente"+
                    "\n8. -Salir\n");
        }
        public static void Opcion1(int[] array)
        {


        }
    }
}
