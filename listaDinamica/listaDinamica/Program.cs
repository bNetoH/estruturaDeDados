using System;

namespace listaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista itens = new Lista();

            itens.Inserir("Areia fina");
            itens.Inserir("Brita");
            itens.Inserir("Areia grossa");
            itens.Inserir("Cimento");
            itens.Inserir("Cerâmica");
            itens.Inserir("Porcelanato");
            itens.Inserir("Rejunte");
            itens.Inserir("Argamassa");
            itens.Inserir("Vedacit");


            itens.Imprimir();
            itens.Inserir("Cal", 1);
            itens.Imprimir();


            itens.Inserir("Construtor", 3);
            itens.Imprimir();

            itens.Inserir("Ajudante", 30);


            itens.Inserir("Ronnie", 3);
            itens.Imprimir();

            itens.Excluir(3);

            if (itens.Procurar("Rejunte"))
            {
                Console.WriteLine("");
            }            
            else
            {

            }

            itens.Ordenar(0); // 0 crescente !=0 decrescente
            itens.Imprimir();
        }
    }
}
