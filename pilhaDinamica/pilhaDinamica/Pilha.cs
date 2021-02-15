using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamica
{
    class Pilha
    {
        NOH topo = null;
        int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public void Inserir(string Valor)
        {
            NOH nn = new NOH();
            nn.Valor = Valor;
            nn.Anterior = topo;
            topo = nn;
            quantidade++;
        }

        public void Imprimir()
        {
            NOH auxT = topo;
            int auxQ = quantidade;
                      
            if (auxQ > 0)
            {
                while (auxQ > 0)
                {
                    Console.WriteLine(auxT.Valor);
                    auxT = auxT.Anterior;
                    auxQ--;
                }                 
            }
            else
            {
                Console.WriteLine("Pilha está vazia.");
            }
        }

        public void Excluir()
        {
            if (quantidade > 0)
            {
                topo = topo.Anterior;
                quantidade--;
            }
            else
            {
                Console.WriteLine("Pilha está vazia.");
            }
        }
    }
}
