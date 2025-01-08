using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gerador de tabuada

            Console.Write("Digite um Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Até qual número deseja multiplicar ? ");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Tabuada do " + numero + "!");

            for (int i = 0; i <= limite; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }
        }
    }
}
