using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_TesteCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicional");

            int idade = 15;
            int qtdPessoas = 0;

            if (idade >= 18 || qtdPessoas >= 2)
            {
                Console.WriteLine("Maior de idade !");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
            Console.ReadLine();

        }
    }
}
