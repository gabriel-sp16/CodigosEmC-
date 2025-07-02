using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesLogicas
{
    internal class SomaDeNumerosPositivos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Esse algoritimo ira fazer a soma de numeros possitivos apenas");

            int numero, contador, resultado;  
           
            do
            {
                Console.WriteLine("Digite um valor a ser somado");
                numero = Convert.ToInt32(Console.ReadLine());
                contador = numero + numero;
                Console.WriteLine(contador);
                contador += numero;
            
                

            } while (numero> -1);
        }    
    }
}
