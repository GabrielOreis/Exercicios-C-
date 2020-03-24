using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosComArquivos.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Product(string name, double price, int quantity)
        {
            Nome = name;
            Valor = price;
            Quantidade = quantity;
        }

        public double Total()
        {
            return Valor * Quantidade;
        }
    }
}
