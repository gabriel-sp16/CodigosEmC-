using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class SwithwCaseExemplo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um valor para ver qual é o dia da semana");
            int diaDaSemana = Convert.ToInt32(Console.ReadLine());

            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("domingo");
                    break;
                    case 2:
                    Console.WriteLine("segunda");
                    break;
                    case 3:
                    Console.WriteLine("terça");
                    break;
                    case 4:
                    Console.WriteLine("quarta");
                    break;
                    case 5:
                    Console.WriteLine("quinta");
                    break;
                    case 6:
                    Console.WriteLine("sexta");
                    break;
                    case 7:
                    Console.WriteLine("sabado");
                    break;
                    default:
                    Console.WriteLine("valor invalido");
                    break;

            }
        }
    }
}
