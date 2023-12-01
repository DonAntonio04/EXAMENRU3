using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRU3
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Year { get; set; }

        public Carro(string marca,string modelo,int year)
        {
            Marca = marca;
            Modelo = modelo;
            Year= year;
        } 

    }
}
