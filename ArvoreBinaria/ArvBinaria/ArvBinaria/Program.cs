using System;

namespace ArvBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore AB = new Arvore();

            Console.WriteLine("Inserção do conjunto A");
            Console.WriteLine("---------------------------");

            int[] A = {21,16,28,9,18,23,31,7,12,17,20};

            for (int i = 0; i < A.Length; i++)
            {
                AB.Inserir(A[i]);
            }

            AB.Criar();

            Console.WriteLine();
            Console.WriteLine("Inserção do conjunto Z");
            Console.WriteLine("---------------------------");

            int[] Z = {31,28,23,21,20,18,17,16,12,9,7};

            for (int i = 0; i < Z.Length; i++)
            {
                AB.Inserir(Z[i]);
            }
            Console.ReadKey();
        }
    }
}
