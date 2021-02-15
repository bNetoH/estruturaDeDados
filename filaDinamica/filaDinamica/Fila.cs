using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaDinamica
{
    class Fila
    {
        Noh inicio;
        Noh fim;
        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public void Inserir(string Valor)
        {
            Noh nn = new Noh();

            if (quantidade == 0)
            {
                nn.Valor = Valor;
                nn.Anterior = null;
                nn.Posterior = null;
                inicio = nn;
                fim = nn;
            }
            else
            {
                nn.Valor = Valor;
                fim.Posterior = nn;
                nn.Anterior = fim;
                nn.Posterior = null;
                fim = nn;
            }
            quantidade++;
        }

        public void Excluir()
        {
            if (quantidade > 0)
            {
                inicio = inicio.Posterior;
                inicio.Anterior = null;
                quantidade--;
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }

        }

        public void Imprimir()
        {
            if (quantidade > 0)
            {
                Noh auxI = inicio;

                Console.WriteLine("+-----------------------------------------+");
                Console.WriteLine(" #            Descrição");
                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine(" "+i +" " + auxI.Valor);
                    auxI = auxI.Posterior;
                }
                Console.WriteLine("+-----------------------------------------+");                
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Pesquisar(string valor)
        {
            if (quantidade > 0)
            {
                Noh auxI = inicio;
                int achou = 0;

                for(int i = 1; i <= quantidade; i++)
                {
                    if (auxI.Valor == valor)
                    {
                        Console.WriteLine("Localizado no indice "+ i);
                        achou++;
                    }                                                            
                    auxI = auxI.Posterior;
                }
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Resultado: " + achou + " correspondências locaizadas");
                Console.WriteLine("----------------------------------------------------");                
            }
            else
            {
                Console.WriteLine("Fila vazia!");
            }
            Console.ReadKey();
            Console.Clear();            
        }
    }            
}
