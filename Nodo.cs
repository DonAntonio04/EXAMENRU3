using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRU3
{
     public class Nodo
     {
        public Carro _datos;
        public Nodo _Siguiente; 
         
        public Nodo(Carro valor)
        {
            _datos = valor;
            _Siguiente = null;
        }
        public Nodo(Carro valor,Nodo siguiente)
        {
            _datos= valor;
            _Siguiente = siguiente;
        }
        public Carro getDatos()
        {
            return _datos;
        }
        public Nodo getSiguiente()
        {
            return _Siguiente;
        }

     }
}
