using System;

namespace Operação_Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            int res;
            Console.WriteLine("Informe o primeiro numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação matematica: 1)Soma 2)Divisao 3)Multiplicação 4)Subsituição");
            res = Convert.ToInt32(Console.ReadLine());
            if (res == 1)
            {
                Console.WriteLine("Seu resultado é {0}", n1 + n2);
            }
            else
                if (res == 2)
            {

                Console.WriteLine("Seu resultado é {0}", n1 / n2);
            }
            if (res == 3)
            {
                Console.WriteLine("Seu resultado é {0}", n1 * n2);
            }
            else

            if (res == 4)
            {
                Console.WriteLine("Seu resultado é {0}", n1 - n2);
            }



        }
    }
}