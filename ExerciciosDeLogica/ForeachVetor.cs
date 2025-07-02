using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class ForeachVetor
    {
        public static void Main(string[]args) 
        {
            string[] marcas = { "Dooge", "Mclaren", "Buggati", "Mustang" };

            foreach (string carro in marcas) 
            {
            
            Console.WriteLine(carro);

            }
        }
    }
}
