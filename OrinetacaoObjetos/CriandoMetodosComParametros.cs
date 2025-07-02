using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrinetacaoObjetos
{
    internal class CriandoMetodosComParametros
    {
        static void Name(string name)
        {
            Console.WriteLine(name + "Souza");
        }

        public static void Main(string[] args)
        {
            Name("Gabriel");
            Name("Abel");
            Name("Lucas");
       }
    }
}
