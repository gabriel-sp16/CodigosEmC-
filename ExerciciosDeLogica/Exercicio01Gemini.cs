using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class Exercicio01Gemini
    {
        public static void Main(string[]args) 
        {
            int[] valores = { 5, 10, 15, 20, 30 };
            int totalSoma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                totalSoma += valores[i];

            }
            Console.WriteLine(totalSoma);
        }
    }
}
