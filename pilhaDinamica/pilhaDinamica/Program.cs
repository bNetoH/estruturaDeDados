using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha nomes = new Pilha();

            Console.WriteLine("Lista de Professores ADS 3º Semestre");
            nomes.Inserir("Ronnie");
            nomes.Inserir("Saulo");
            nomes.Inserir("Alexandre");
            nomes.Inserir("Sebastião");

            nomes.Imprimir();

            Console.ReadKey();
            
            nomes.Excluir();

            nomes.Inserir("Luciana");

            Console.WriteLine();
            Console.WriteLine("Lista de Professores ADS 3º Semestre");
            nomes.Imprimir();

            Console.ReadKey();

        }
    }
}
