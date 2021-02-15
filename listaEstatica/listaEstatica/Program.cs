using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Lista Estárica\n\n");

            // criando instância da classe lista 
            lista nomes = new lista(5);

            int t = 1;
            string resp = "S";
            string texto;
            int text1, text2;
            
                    
            while (t != 0)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(" Gerenciador de Cadastro");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("> Serviços:");
                Console.WriteLine("> 1 - Inserir no final da lista");
                Console.WriteLine("> 2 - Inserir no meio da lista");
                Console.WriteLine("> 3 - Imprimir lista");
                Console.WriteLine("> 4 - Imprimir intervalo da lista");
                Console.WriteLine("> 5 - Alterar nome");
                Console.WriteLine("> 6 - Ordenar lista");
                Console.WriteLine("> 7 - Procurar");
                Console.WriteLine("> 8 - Excluir último da lista");
                Console.WriteLine("> 9 - Excluir um registro especifico");
                Console.WriteLine("> 0 - Sair");
                Console.WriteLine("-------------------------------------");
                Console.Write("> Escolha uma opção: ");
                t = Convert.ToInt16(Console.ReadLine());

                if (t == 1)
                {
                    while (resp == "S" || resp == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine(" 1 - Inserir Nomes ");
                        Console.WriteLine("-------------------------------------");
                        Console.Write("Nome...: ");
                        texto = Console.ReadLine();
                        if (texto == string.Empty)
                        {
                            Console.WriteLine();
                            Console.WriteLine(">>> Atenção! Campo nome inválido, tente novamente! <<<");                            
                        }
                        else
                        {
                            nomes.Inserir(texto);
                            Console.Clear();
                            nomes.Imprimir();
                        }
                        Console.WriteLine();
                        Console.Write(" Continuar inserindo? [S/N]: ");
                        resp = Console.ReadLine();
                    }                    
                }

                if (t == 2)
                {
                    Console.Clear();
                    nomes.Imprimir();
                    Console.WriteLine();                        
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 2 - Inserir Nome na posição");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Nome...: ");
                    texto = Console.ReadLine();
                    Console.Write("Posição: ");
                    text1 = Convert.ToInt16(Console.ReadLine());
                    nomes.Inserir(texto,text1);
                    Console.Clear();
                    nomes.Imprimir();
                    Console.ReadKey();
                }

                if (t == 3)
                {
                    Console.Clear();                    
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 3 - Lista Completa");
                    nomes.Imprimir();
                    Console.ReadKey();
                }

                if (t == 4)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 4 - Intervalo da lista ");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("De...: ");
                    text1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Até..: ");
                    text2 = Convert.ToInt16(Console.ReadLine());                    
                    nomes.Imprimir(text1, text2);
                    Console.ReadKey();
                }

                if (t == 5)
                {
                    Console.Clear();
                    nomes.Imprimir();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 5 - Alterar Nome ");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Novo nome..: ");
                    texto = Console.ReadLine();
                    Console.Write("Posição....: ");
                    text1 = Convert.ToInt16(Console.ReadLine());
                    nomes.Alterar(texto, text1);
                    Console.Clear();
                    nomes.Imprimir();
                    Console.ReadKey();
                }

                if (t == 6)
                {                    
                    nomes.Ordenar();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 6 - Lista completa ordenada ");    
                    nomes.Imprimir();
                    Console.ReadKey();
                }

                if (t == 7)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 7 - Procurar nome");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Nome...: ");
                    texto = Console.ReadLine();
                    nomes.Procurar(texto);                    
                }

                if (t == 8)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 8 - Excluir último da lista");
                    Console.WriteLine("-------------------------------------");
                    Console.Write(" Confirma exclusão [S/N]: ");
                    resp = Console.ReadLine();
                    if (resp == "s" || resp == "S")
                    {
                        nomes.Excluir();
                    }
                    else
                    {
                        Console.WriteLine(" Exclusão cancelada");
                    }                    
                }

                if (t == 9)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" 9 - Excluir registro específico");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Posição: ");
                    text1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write(" Confirma exclusão [S/N]: ");
                    resp = Console.ReadLine();
                    if (resp == "s" || resp == "S")
                    {
                        nomes.Excluir(text1);
                    }
                    else
                    {
                        Console.WriteLine(" Exclusão cancelada");
                    }
                }

                if (t == 0)
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(">>>       Programa encerrado      <<<");
                    Console.WriteLine("-------------------------------------");
                    Console.ReadKey();
                }
            }
        }
    }
}
