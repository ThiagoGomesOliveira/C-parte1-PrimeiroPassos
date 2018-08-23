using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            float pontoFlutuante = 3.14f;

            double salario = 1220.50;
            int salarioInteiro = (int)salario;
            Console.WriteLine("Número com casting "+salarioInteiro);
            Console.WriteLine("Número sem Casting " + salario);
            Console.ReadLine();

            double valor1 = 0.1;
            double valor2 = 0.2;

            int total = (int)valor1 + (int)valor2;

            Console.WriteLine("Total "+ total);

            Console.WriteLine("Ponto Flutuante  " + pontoFlutuante);

            double teste = 30.0;
            Console.WriteLine("Ponto Flutuante  " + (int)teste +"!");

            Console.ReadLine();

        }
    }
}
