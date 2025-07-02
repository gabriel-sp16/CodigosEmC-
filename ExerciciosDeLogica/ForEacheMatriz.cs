using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class ForEacheMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 0, 5, 7 }, { 5, 4, 8, 9 } };
            foreach (int i in numero) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
