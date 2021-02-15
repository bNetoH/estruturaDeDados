using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaestatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilha Estárica\n\n");

            // criando instância da classe pilha
            pilha livros = new pilha(8);

            // empilhando inf.na pilha livros
            livros.empilhar("A");
            livros.empilhar("B");
            livros.empilhar("C");
            livros.empilhar("D");
            livros.empilhar("E");
            livros.empilhar("F");
            livros.empilhar("G");
            livros.empilhar("H");

            /*
            for (int i =0; i < 8; i++)
            {
                Console.WriteLine("Digite o titulo de um livro: ");
                livros.empilhar(Console.ReadLine());
            }
            */

            //metodo imprimir - mostra nome dos livros armazenados
            Console.WriteLine("Resultado 1a impressão");
            livros.imprimir();

            // metodo para tirar o livro do topo
            livros.desempilhar();

            Console.WriteLine("Resultado 2a impressão");
            livros.imprimir();

            Console.ReadKey(); // parar execuçao para visualizar resultado
         }
    }
}
