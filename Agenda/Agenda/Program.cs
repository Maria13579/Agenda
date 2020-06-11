using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static string[,] agenda = new string[4, 10];
        
        static void Main(string[] args)
        {
            string usuario = "Contacto no encontrado";
            string buscar = "";
            string buscar2 = "";
            int opc=0;
            while (opc<4)
            { 
                Console.WriteLine("--------- Menú de Opciones ---------");
                Console.WriteLine("1. Ingresar contactos");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Ingrese el numero de opción que desea: ");
                opc =int.Parse(Console.ReadLine());
                if (opc >= 1)
                {
                    if (opc < 5)
                    {
                        if (opc == 1)
                        {
                            for (int f = 0; f < 10; f++)
                            {
                                Console.WriteLine("Digite el nombre: ");
                                agenda[0, f] = Console.ReadLine();
                                Console.WriteLine("Digite su apellido: ");
                                agenda[1, f] = Console.ReadLine();
                                Console.WriteLine("Ingrese su direccion: ");
                                agenda[2, f] = Console.ReadLine();
                                Console.WriteLine("ingrese su número telefonico: ");
                                agenda[3, f] = Console.ReadLine();

                                Console.Clear();
                            }

                        }
                        if (opc == 2)
                        {
                            Console.WriteLine("-------------------------Datos Ingresados-------------------------");
                            for (int f = 0; f < 10; f++)
                            {       
                                Console.WriteLine(agenda[0, f] + "    " + agenda[1, f] + "    " + agenda[2, f] + "    " + agenda[3, f]);
                            }
                            Console.WriteLine("------------------------------------------------------------------");
                            
                        }
                        if (opc == 3)
                        {
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Ingrese nombre de la persona que desea buscar");
                            buscar = Console.ReadLine();
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Ingrese apellido de la persona que desea buscar");             
                            buscar2 = Console.ReadLine();
                            Console.WriteLine("-----------------------------------------------");
                            for (int f = 0; f < 10; f++)
                            {
                                if (buscar == agenda[0, f] && buscar2 == agenda[1, f])
                                {
                                    usuario = agenda[0, f] + "    " + agenda[1, f] + "    " + agenda[2, f] + "    " + agenda[3, f];
                                }
                            }
                            Console.WriteLine("Datos del contacto buscado: ");
                            Console.WriteLine(usuario);
                            Console.WriteLine("____________________________________________________");
                            Console.WriteLine("\n\n");
                        }
                     
                    }
                    else
                    {
                        Console.WriteLine("Ese número de opcion no existe");
                    }
                }
                else
                {
                    Console.WriteLine("Ese número de opcion no existe");
                }
                
            }
            if(opc==4)
            {
                Console.WriteLine("Gracias por usar nuestra aplicacion");
            }
            Console.ReadKey();
        }

    }
}

