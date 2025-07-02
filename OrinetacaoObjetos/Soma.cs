using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrinetacaoObjetos
{
    internal class Soma
    {
        public static void Main(string[]args) 
        {
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2=Convert.ToInt32(Console.ReadLine());
           int Soma = n1 + n2;

            Console.WriteLine(Soma);
        }
    }
}
