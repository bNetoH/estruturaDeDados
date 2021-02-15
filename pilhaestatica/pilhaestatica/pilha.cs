using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaestatica
{
    class pilha // nome da classe
    {
        /* propriedades = variáveis, normalmente são 
         * privadas e só poderão ser acessadas por metodos */
        int topo, limite;
        // string[] valores = new string[8];         
        string[] valores;

        /* construtor da classe - é opcional + muito comum 
         * que existam construtores e devem ser "public" e ter 
         * o mesmo nome da classe */
        public pilha(int tamanho) // nome do construtor
        {
            if (tamanho > 0)
            {
                valores = new string[tamanho];
                topo = 0;
                limite = tamanho;
            }
            else
            {
                Console.WriteLine("tamanho fora do limite");
            }
        }

        public void empilhar(string valor)
        {
            if (topo < limite)
            {
                valores[topo] = valor;
                topo++;
            }    
            else
            {
                Console.WriteLine("Pilha está cheia");
            }        
        } 
        
        public void imprimir()
        {
            if (topo > 0)
            {
                for (int i = (topo-1); i >= 0; i--)
                {
                    Console.WriteLine(valores[i]);
                }
            }
            else
            {
                Console.WriteLine("Pilha está vazia");
            }
        }
        
        public void desempilhar()
        {
            if(topo > 0)
            {
                topo--;
            }
            else
            {
                Console.WriteLine("Pilha está vazia");
            }
        }       
    }
}