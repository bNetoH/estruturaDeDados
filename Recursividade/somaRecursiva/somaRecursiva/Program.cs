using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma n = new Soma();

            while (n.Terminar == 0)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("  Total......: " + n.Valor);
                Console.WriteLine("------------------------------");
                Console.Write("  + ");
                n.Somar(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("  Total......: " + n.Valor);
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine(">>> Pressione qualquer tecla para fechar <<<");
            Console.ReadKey();
        }
    }
}