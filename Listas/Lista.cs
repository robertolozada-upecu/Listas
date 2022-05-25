using System;

namespace Listas
{
    public class Lista
    {
        private Nodo inicio;
        private Nodo fin;

        public Lista()
        {
            inicio = fin = null;
        }

        public Nodo getInicio()
        {
            return inicio;
        }

        public void agregarInicio(Auto auto)
        {
            Nodo nodo = new Nodo(auto);
            if (inicio == fin && inicio == null)
            {
                inicio = fin = nodo;
            }
            else
            {
                nodo.setSiguiente(inicio);
                inicio.setAnterior(nodo);
                inicio = nodo;
            }
        }

        public void agregarFin(Auto auto)
        {
            Nodo nodo = new Nodo(auto);
            if (fin == inicio && fin == null)
            {
                fin = inicio = nodo;
            }
            else
            {
                fin.setSiguiente(nodo);
                nodo.setAnterior(fin);
                fin = nodo;
            }
        }

        public void Imprimir()
        {
            Nodo actual = inicio;
            if (actual == null)
            {
                Console.WriteLine();
                Console.WriteLine("¡La lista se encuentra vacía!");
            }
            else
            {
                int contadorAutos = 1;
                Console.Clear();
                Console.WriteLine("---- Listado total de autos ----");
                while (actual != null)
                {
                    Console.WriteLine("------- " + contadorAutos + " --------");
                    Console.WriteLine("Marca: " + actual.getAuto().getMarca());
                    Console.WriteLine("Modelo: " + actual.getAuto().getModelo());
                    Console.WriteLine("Precio: " + actual.getAuto().getPrecio());
                    Console.WriteLine("Unidades disponibles: " + actual.getAuto().getCantidadUnidades());
                    actual = actual.getSiguiente();
                    contadorAutos++;
                }
            }
        }

        public void imprimirDesdeFin()
        {
            Nodo actual = fin;
            if (actual == null)
            {
                Console.WriteLine();
                Console.WriteLine("¡La lista se encuentra vacía!");
            }
            else
            {
                int contadorAutos = 1;
                Console.Clear();
                Console.WriteLine("---- Listado total de autos desde el fin ----");
                while (actual != null)
                {
                    Console.WriteLine("------- " + contadorAutos + " --------");
                    Console.WriteLine("Marca: " + actual.getAuto().getMarca());
                    Console.WriteLine("Modelo: " + actual.getAuto().getModelo());
                    Console.WriteLine("Precio: " + actual.getAuto().getPrecio());
                    Console.WriteLine("Unidades disponibles: " + actual.getAuto().getCantidadUnidades());
                    actual = actual.getAnterior();
                    contadorAutos++;
                }
            }
        }

        public bool ListaVacia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public void eliminarNodoListaSimple(string modelo)
        {
            Nodo anterior = inicio;
            Nodo nodoEliminar = null;
            while (nodoEliminar == null)
            {
                if (anterior.getSiguiente().getAuto().getModelo() == modelo)
                    nodoEliminar = anterior.getSiguiente();
                else
                    anterior = anterior.getSiguiente();
            }
            if (nodoEliminar != inicio && nodoEliminar != fin)
            {
                anterior.setSiguiente(nodoEliminar.getSiguiente());
            }
        }

        public void eliminarNodoListaDobleEnlazada(string modelo)
        {
            Nodo actual = inicio;
            Nodo anterior = null;
            //Nodo nodoEliminar = null;
            bool nodoEncontrado = false;
            //Si la lista se encuentra vacía
            if (inicio == null)
            {
                Console.WriteLine("¡No se puede eliminar ningún auto, la lista se encuentra vacía!");
            }
            else
            {
                //Si la lista tiene un solo elemento
                if (inicio == fin)
                {
                    if (actual.getAuto().getModelo() == modelo)
                    {
                        inicio = null;
                        fin = null;
                        Console.WriteLine();
                        Console.WriteLine("Auto Eliminado...");
                        nodoEncontrado = true;
                    }
                }
                else
                {
                    while (actual != null && nodoEncontrado == false)
                    {
                        if (actual.getAuto().getModelo() == modelo)
                        {
                            if (actual == inicio)
                            {
                                inicio = inicio.getSiguiente();
                                inicio.setAnterior(null);
                            }
                            else if (actual == fin)
                            {
                                anterior.setSiguiente(null);
                                fin = anterior;
                            }
                            else
                            {
                                anterior.setSiguiente(actual.getSiguiente());
                                actual.getSiguiente().setAnterior(anterior.getAnterior());
                            }
                            Console.WriteLine();
                            Console.WriteLine("Auto Eliminado...");
                            nodoEncontrado = true;
                        }
                        anterior = actual;
                        actual = actual.getSiguiente();
                    }
                }
                if (!nodoEncontrado)
                {
                    Console.WriteLine();
                    Console.WriteLine("¡El modelo " + modelo + " de auto no fue encontrado, por favor verifique!");
                }
            }
        }

        public int sumaRecursiva(Nodo aux)
        {
            if (aux != null)
            {
                if (aux != fin)
                    return 1 + sumaRecursiva(aux.getSiguiente());
                else
                    return 1;
            }
            else
                return 0;
        }

        public double PromedioPrecioAutos(Nodo aux)
        {
            if (aux != null)
            {
                if (aux != fin)
                    return aux.getAuto().getPrecio() + PromedioPrecioAutos(aux.getSiguiente());
                else
                    return aux.getAuto().getPrecio();
            }
            else
                return 0;
        }

        public double TotalActivoAutos(Nodo aux)
        {
            if (aux != null)
            {
                if (aux != fin)
                    return (aux.getAuto().getPrecio() * aux.getAuto().getCantidadUnidades()) + TotalActivoAutos(aux.getSiguiente());
                else
                    return aux.getAuto().getPrecio() * aux.getAuto().getCantidadUnidades();
            }
            else
                return 0;
        }
    }
}
