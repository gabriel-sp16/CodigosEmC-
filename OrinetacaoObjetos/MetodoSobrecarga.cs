using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrinetacaoObjetos
{
    internal class MetodoSobrecarga
    {
        static int Soma(int valor1 ,int valor2)
        {
           
            return valor1 + valor2;
        }

        static double Soma(double valor1, double valor2)
        {
            
            return valor1 + valor2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para efetuar a soma");

            Console.WriteLine("Digite o primeiro valor");

            int numero1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");

            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma dos numeros inteiros é: ");
            Console.WriteLine(Soma(numero1,numero2));
            
        }
    }
}
