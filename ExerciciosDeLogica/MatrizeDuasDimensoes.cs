using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class MatrizeDuasDimensoes
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 1, 5, 8 }, { 2, 6, 9 } };

            Console.WriteLine(numeros[0, 2]);
            Console.WriteLine(numeros[1, 2]);
            Console.WriteLine(numeros[0, 2]);
        }
    } }
