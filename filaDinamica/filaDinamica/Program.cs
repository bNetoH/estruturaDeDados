using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila itens = new Fila();
            
            itens.Inserir("Bolha");
            itens.Inserir("Bola");
            itens.Inserir("Apito");
            itens.Inserir("Chuteiras");
            itens.Inserir("Meias");
            itens.Inserir("Meias");
            itens.Inserir("Meias");
            itens.Inserir("Meias");
            itens.Inserir("Calção");
            itens.Inserir("Calção");
            itens.Inserir("Calção");
            itens.Inserir("Camiseta oficial");
            itens.Inserir("Camiseta oficial");
            itens.Inserir("Camiseta reserva");
            itens.Inserir("Camiseta reserva");

            itens.Imprimir();

            string procurado = "Meias";
            Console.WriteLine("\nExecutar pesquisa pelo item "+procurado+"\n");
            itens.Pesquisar(procurado);

            procurado = "Chuteiras";
            Console.WriteLine("\nExecutar pesquisa pelo item " + procurado+"\n");
            itens.Pesquisar(procurado);

            procurado = "Bolha";
            Console.WriteLine("\nExecutar pesquisa pelo item " + procurado + "\n");
            itens.Pesquisar(procurado);


            Console.WriteLine("\nExecutar exclusão do primeiro item da fila\n");
            itens.Excluir();
            
            procurado = "Bolha";
            Console.WriteLine("\nExecutar pesquisa pelo item " + procurado + "\n");
            itens.Pesquisar(procurado);
        }
    }
}
