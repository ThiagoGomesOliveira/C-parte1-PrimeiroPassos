using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AliquotaIfs
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario  =3300.0;
            double salarioDesconto;

            if (salario >=  1900.0  && salario <= 2800.0)
            {
                salarioDesconto = salario - 142;
                Console.WriteLine(salarioDesconto);
                Console.ReadLine();
            }
            if (salario >= 2800.01 && salario <= 3751.0 )
            {
                salarioDesconto = salario - 350;
                Console.WriteLine(salarioDesconto);
                Console.ReadLine();
            }
            if (salario >= 3751.01 && salario <= 4664.00)
            {
                salarioDesconto = salario - 636;
                Console.WriteLine(salarioDesconto);
                Console.ReadLine();

            }



        }
    }
}
