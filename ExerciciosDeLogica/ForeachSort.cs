using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class ForeachSort
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Maserati", "R34", "BMW", "LaFerrari" };
            Array.Sort(carro);
            foreach (string marca in carro)
            {

                Console.WriteLine(marca);
            }
            int[] numero = { 15, 32, 63, 14, 95, 86, };

            //para colocar a ordem do maior para o menor
            //Array.Reverse(numero);

            //para colocar os numeros em ordem do menor para o maior
            Array.Sort(numero);

            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}
