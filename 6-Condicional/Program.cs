using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicional");

            int idade = 15;
            int qtdPessoas = 0;

            if (idade >= 18 )
            {
                Console.WriteLine("Maior de idade !");
            }
            else
            {
                if (qtdPessoas >=2)
                {
                    Console.WriteLine("Menor de idade ! Está acompanhado ");
                }
                else
                {
                    Console.WriteLine("Menor de idade !");
                }
            }
            Console.ReadLine();

        }
    }
}
