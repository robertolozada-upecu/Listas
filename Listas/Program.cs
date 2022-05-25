using System;

namespace Listas
{
    internal class Program
    {
        static void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("-------------- Ejercicios con Listas -------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Mostrar Listado completo");
            Console.WriteLine("2. Añadir Auto al inicio");
            Console.WriteLine("3. Añadir Auto al final");
            Console.WriteLine("4. Eliminar Auto");
            Console.WriteLine("5. Sumatoria Total de Autos ingresados");
            Console.WriteLine("6. Promedio de precio de autos");
            Console.WriteLine("7. Total de activo en autos");
            Console.WriteLine("8. Mostrar Autos desde el Fin");
            Console.WriteLine("9. Salir");
            Console.Write("Ingrese una opción: ");
        }
        static void Main(string[] args)
        {
            string opcionMenu;
            Lista listaAutos=new Lista();
            do
            {
                ImprimirMenu();
                opcionMenu = Console.ReadLine();
                switch (opcionMenu)
                {
                    case "1":
                        listaAutos.Imprimir();
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.Write("Ingrese la Marca: ");
                        string marca = Console.ReadLine();
                        Console.Write("Ingrese el Modelo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Ingrese el Precio: ");
                        double precio = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el número de Unidades: ");
                        int cantidadUnidades = int.Parse(Console.ReadLine());
                        Auto autoInicio = new Auto(marca, modelo,precio,cantidadUnidades);
                        listaAutos.agregarInicio(autoInicio);
                        Console.WriteLine();
                        Console.WriteLine("Auto Agregado...");
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.Write("Ingrese la Marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Ingrese el Modelo: ");
                        modelo = Console.ReadLine();
                        Console.Write("Ingrese el Precio: ");
                        precio = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el número de Unidades: ");
                        cantidadUnidades = int.Parse(Console.ReadLine());
                        Auto autoFin = new Auto(marca, modelo, precio, cantidadUnidades);
                        listaAutos.agregarFin(autoFin);
                        Console.WriteLine();
                        Console.WriteLine("Auto Agregado...");
                        break;

                    case "4":
                        if (!listaAutos.ListaVacia())
                        {
                            Console.WriteLine();
                            Console.Write("Ingrese el Modelo del auto a eliminar: ");
                            string modeloEliminar = Console.ReadLine();
                            listaAutos.eliminarNodoListaDobleEnlazada(modeloEliminar);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("¡No se puede eliminar ningún auto, la lista se encuentra vacía!");
                        }
                        break;

                    case "5":
                        if (!listaAutos.ListaVacia())
                        {
                            Console.WriteLine();
                            Console.WriteLine("Número de Autos...");
                            Console.WriteLine(listaAutos.sumaRecursiva(listaAutos.getInicio()));
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("¡No existen autos, la lista se encuentra vacía!");
                        }
                        break;

                    case "6":
                        if (!listaAutos.ListaVacia())
                        {
                            Console.WriteLine();
                            Console.WriteLine("Promedio de Autos...");
                            Console.WriteLine(listaAutos.PromedioPrecioAutos(listaAutos.getInicio()) / listaAutos.sumaRecursiva(listaAutos.getInicio()));
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("¡No se puede calcular el promedio, la lista se encuentra vacía!");
                        }
                        break;

                    case "7":
                        if (!listaAutos.ListaVacia())
                        {
                            Console.WriteLine();
                            Console.WriteLine("Total Activo de Autos...");
                            Console.WriteLine(listaAutos.TotalActivoAutos(listaAutos.getInicio()));
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("¡No se puede calcular el total de activos, la lista se encuentra vacía!");
                        }
                        break;

                    case "8":
                        listaAutos.imprimirDesdeFin();
                        break;

                    case "9":
                        Console.WriteLine();
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("¡Opción no válida!");
                        break;
                }
                Console.WriteLine();
                Console.Write("Presione enter para continuar ");
                Console.ReadKey();
            } while (opcionMenu != "9");
        }
    }
}
