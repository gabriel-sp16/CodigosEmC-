using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class ExemploDeConstrutorComParametro
    {
        public string modelo;

        public ExemploDeConstrutorComParametro(string nomemodelo)
        {
            modelo = nomemodelo;
        }

        public static void Main(string[] args)
        {
            ExemploDeConstrutorComParametro chevrolet = new ExemploDeConstrutorComParametro("Vectra");

            Console.WriteLine(chevrolet.modelo);    

        }
    }
}
