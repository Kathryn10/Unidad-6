using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UNIDAD6
{
    class Program
    {
        public class InventarioDeAmazon
        {
            public string nombreProducto, descripcion;
            public float precio;
            public int cantidadStock;

            public InventarioDeAmazon(string nombreProducto, string descripcion, float precio, int cantidadStock)
            {
                this.nombreProducto = nombreProducto;
                this.descripcion = descripcion;
                this.precio = precio;
                this.cantidadStock = cantidadStock;
            }

            public void DesplegarDatos()
            {
                Console.WriteLine("***DATOS DEL PRODUCTO***");
                Console.WriteLine("Nombre del prodcuto: " + nombreProducto);
                Console.WriteLine("Descripción del producto: " + descripcion);
                Console.WriteLine("Precio del producto: {0:C}", precio);
                Console.WriteLine("Cantidad del producto en stock: " + cantidadStock);
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Productos.txt", true);

            string nombreProducto, descripcion;
            float precio;
            int cantidadStock;
            int opcion;

            try
            {
                do
                {
                    Console.WriteLine("\n***PRODUCTOS DE AMAZON***");
                    Console.WriteLine("1.- Datos del producto");
                    Console.WriteLine("2.- Salida del programa");
                    Console.Write("\nIngresa la opción: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write("\nEscribe el nombre del producto: ");
                                nombreProducto = Console.ReadLine();
                                Console.Write("Escribe la descripción del producto: ");
                                descripcion = Console.ReadLine();
                                Console.Write("Escribe el precio del producto: ");
                                precio = float.Parse(Console.ReadLine());
                                Console.Write("Escribe la cantidad en stock del producto: ");
                                cantidadStock = int.Parse(Console.ReadLine());

                                Console.Clear();

                                InventarioDeAmazon I1 = new InventarioDeAmazon(nombreProducto, descripcion, precio, cantidadStock);

                                I1.DesplegarDatos();

                                sw.WriteLine(I1.nombreProducto + "\t" + I1.descripcion + "\t" + I1.precio + "\t" + I1.cantidadStock);
                            }
                            sw.Close();

                            Console.WriteLine("\nEscribiendo en el archivo...");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Write("\nPresione ENTER para salir del programa");
                            Console.ReadKey();
                            break;

                        default:
                            Console.Write("\nEsa opción no corresponde con las existentes, presione ENTER para continuar...");
                            Console.ReadKey();
                            break;
                    }

                } while (opcion != 2);
            }
            catch(Exception x)
            {
                Console.WriteLine("\nError: " + x.Message);
                Console.ReadKey();
            }
        }
    }
}
