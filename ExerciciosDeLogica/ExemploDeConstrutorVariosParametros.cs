using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class ExemploDeConstrutorComVariosParametros
    {
        public string modelo;
        public string cor;
        public int ano;
        public string marca;
        public int presco;

        public ExemploDeConstrutorComVariosParametros(string nomemodelo, string modeloCor, int modeloAno, string modeloMarca, int modeloPresco)
        {
            modelo = nomemodelo;
            cor = modeloCor;
            ano = modeloAno;
            marca = modeloMarca;
            presco = modeloPresco;
          
        }

        public static void Main(string[] args)
        {
            ExemploDeConstrutorComVariosParametros chevrolet = new ExemploDeConstrutorComVariosParametros("Vectra", "preto", 2000, "Chevrolet", 65000);

            Console.WriteLine($"voce tem um {chevrolet.modelo},de cor {chevrolet.cor},de ano {chevrolet.ano},com o valor de {chevrolet.presco}");

        }
    }
}
