using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class ContagemRegressiva
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Esse algoritimo ira fazer uma contagem regresiva com o numero que o usuario solicitar\n");

            int numero;

            Console.WriteLine("Digite o valor(Por favor,digitar so numero inteiros como 1 ou 10)\n");
            numero=Convert.ToInt32(Console.ReadLine());

            do      
            {
                numero--;
                Console.WriteLine(numero);
                
            }while (numero >0);  
        }
    }
}
