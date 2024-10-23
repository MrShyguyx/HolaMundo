using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo");

            // Programa que divida dos numeros

            //Declarar Las Variables
            double num1, num2, division;

            Console.Write("Ingrese primer numero: ");
         
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese segundo numero: ");
            
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            division =num1 / num2;

            //Condicion en caso de que la persona pulse cero por error

            if (division == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");

            }
            else
            {
                Console.WriteLine("Resultado: {0}", division);

            }   


            Console.ReadKey();


        }
    }
}
