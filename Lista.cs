﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRU3
{
    public class Lista
    {
        public Lista()
        {
            _cabeza = null;
        }
        private Nodo _cabeza;


        public int Longitud()
        {
            int longitud = 0;
            Nodo actual = _cabeza;
            while ( actual != null )
            {
               actual = actual.getSiguiente();
                longitud++;
            }
            return longitud;

        }
        public void AgregarCarro(Carro carro)
        {
            Nodo nuevoNodo = new Nodo(carro);
            nuevoNodo._Siguiente = _cabeza;
            _cabeza = nuevoNodo;
        }
        public void OrdenarPoryearDescendente()
        {
            if (_cabeza == null || _cabeza._Siguiente == null)
                return; 

            Nodo nodoActual = _cabeza;

            while (nodoActual != null)
            {
                Nodo nodoSiguiente = nodoActual._Siguiente;

                while (nodoSiguiente != null)
                {
                    if (nodoActual.getDatos().Year < nodoSiguiente.getDatos().Year)
                    {
                        // Intercambiar los datos de los nodos
                        Carro temp = nodoActual.getDatos();
                        nodoActual._datos = nodoSiguiente._datos;
                        nodoSiguiente._datos = temp;
                    }

                    nodoSiguiente = nodoSiguiente._Siguiente;
                }

                nodoActual = nodoActual._Siguiente;
            }
        }

        public void buscarMarca(string Marcabuscada)
        {
            int izquierda = 0;
            int derecho = Longitud() - 1;
            bool encontrado = false;

            while(izquierda <= derecho)
            {
                int contador = 0;
                int medio = izquierda + (derecho - izquierda) / 2;
                Nodo actual = _cabeza;
                while (contador < medio && actual != null)
                {
                    contador++;
                    actual = actual.getSiguiente();
                }
                if (actual != null && actual.getDatos().Marca == Marcabuscada)
                {
                    Console.WriteLine($"La persona con la edad {Marcabuscada} se encuentra en la posición {medio}.");
                    encontrado = true;
                    break;
                }
                else if (actual != null && actual.getDatos().Marca < Marcabuscada)
                {
                    // Si la edad buscada es mayor, buscar en la mitad derecha
                    izquierda = medio + 1;
                }
                else
                {
                    izquierda = medio - 1;
                }
            }
            if(!encontrado)
            {
                Console.WriteLine($"La marca {Marcabuscada} no se encuentra en la lista");
            }


        }
    }
}

