using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class AlterarElementoMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3, 6 }, { 8, 5, 2, 9 } };

            numero[0, 0] = 5;

            Console.WriteLine(numero[0,0]);
        }
    }
}
