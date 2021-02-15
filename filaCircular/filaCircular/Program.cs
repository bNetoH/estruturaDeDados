using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila Circular\n");

            // criando instância da classe fila 
            fila cadeira = new fila(5);

            /* tentativa de sentar 7 pessoas em 5 cadeiras 
             * aguardo aviso erro das últimas 2 tentativas */

            Console.WriteLine("lista de 7 pessoas para se acomodarem em 5 posições : ");

            // enfileirando pessoas na fila
            cadeira.Acomodar("Pedro");
            cadeira.Acomodar("Tiago");
            cadeira.Acomodar("Marcos");
            cadeira.Acomodar("Mateus");
            cadeira.Acomodar("Judas");
            cadeira.Acomodar("João");
            cadeira.Acomodar("Lucas");
                        

            //metodo imprimir - mostra nome das 5 pessoas acomodadas
            Console.WriteLine("Resultado 1a impressão");
            cadeira.Imprimir();
            Console.WriteLine("------------------------------------");

            // metodo para chamar pessoa(s) da fila             
            cadeira.Chamar();            
            cadeira.Imprimir();
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Após incluir mais um no final da lista: ");
            cadeira.Acomodar("João");            
            cadeira.Imprimir();
            Console.WriteLine("------------------------------------");

            // metodo para chamar pessoa(s) da fila             
            cadeira.Chamar();            
            cadeira.Imprimir();
            Console.WriteLine("------------------------------------");

            // metodo para chamar pessoa(s) da fila             
            cadeira.Chamar();
            cadeira.Imprimir();
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Após incluir mais dois no final da lista: ");
            cadeira.Acomodar("Lucas");
            cadeira.Acomodar("José");
            cadeira.Acomodar("Maria");
            cadeira.Imprimir();
            Console.WriteLine("------------------------------------");

            Console.ReadKey(); // parar execuçao para visualizar resultado

        }
    }
}
