using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeLogica
{
    internal class ExemploDeMetodoConstrutor
    {
        class Car
        {
            public string modelo;

            public Car()
            {
                modelo = "Mustang GT500";
            }

            public static void Main(string[] args)
            {
                Car Ford = new Car();
                Ford.modelo = args[0];


                Console.WriteLine(Ford.modelo);
            }
        }
    }
}
