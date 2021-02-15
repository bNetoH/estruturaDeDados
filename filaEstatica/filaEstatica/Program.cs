using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila Estárica\n\n");

            // criando instância da classe fila 
            fila consultorio = new fila(5);

            // enfileirando os ocupantes da fila
            Console.WriteLine("Fila de pessoas no consultório: ");
            // enfileirando pessoas na fila
            consultorio.Enfileirar("Pedro");
            consultorio.Enfileirar("Tiago");
            consultorio.Enfileirar("Marcos");
            consultorio.Enfileirar("Mateus");
            consultorio.Enfileirar("Judas");

            /*
            for (int i =0; i < 5; i++)
            {
                Console.WriteLine("Nome a enfileirar: ");
                pessoas.enfileirar(Console.ReadLine());
            }
            */

            //metodo imprimir - mostra nome das pessoas enfileiradas
            Console.WriteLine("Resultado 1a impressão");
            consultorio.Imprimir();

            // metodo para chamar pessoas da fila 
            consultorio.Desenfileirar();

            Console.WriteLine("Resultado 2a impressão");
            consultorio.Imprimir();

            // metodo para chamar pessoas da fila 
            consultorio.Desenfileirar();

            Console.WriteLine("Resultado 3a impressão");
            consultorio.Imprimir();

            Console.ReadKey(); // parar execuçao para visualizar resultado
        }
    }
}
