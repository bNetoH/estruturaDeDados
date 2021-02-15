/* Operações da lista - vetor de 5 posições
 * 
 * Inserir - ordinal
 * Inserir na posição
 * Excluir último
 * Excluir na posição
 * Imprimir lista ordinal
 * Imprimir intervalo da lista
 * Ordenar lista
 * Alterar posição do item na lista
 * Procurar informação na lista 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaEstatica
{
    class lista
    {
        int limite, inicio, fim;        
        string[] valores;

        public lista(int Tamanho)
        {
            valores = new string[Tamanho];
            inicio = fim = 0;
            limite = Tamanho;
        }

        public void Inserir(string valor)
        {
            if (fim == limite)
            {
                Console.WriteLine(">>> Atenção! A lista está cheia <<<");                
            }
            else
            {
                if (fim < limite)
                {
                    valores[fim] = valor;
                    fim++;
                    Console.WriteLine(">>> Atenção! Nome inserido com sucesso!! <<<");
                }
            }
            finalizar();
        }

        public void finalizar()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void Inserir(string valor, int posicao)
        {
            if (fim == limite)
            {
                Console.WriteLine(">>> Atenção! A lista está cheia <<<");
                Console.ReadKey();
            }
            else
            {
                if (fim < limite)
                {
                    for (int i = 0; i <= (fim - posicao); i++)
                    {
                        valores[fim - i] = valores[fim - (i + 1)];
                    }
                    valores[posicao - 1] = valor;
                    fim++;
                }
            }
        }

        public void Excluir()
        {
            if (fim > 0)
            {                
                fim--;
                valores[fim] = " ";
                Console.WriteLine(">>> Atenção! Registro excluido com sucesso!! <<<");
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }
            finalizar();
        }

        public void Excluir(int posicao)
        {            
            if (fim > 0)
            {
                if (posicao-1 < fim)
                {
                    for (int i = (posicao - 1); i < (fim - 1); i++)
                    {
                        valores[i] = valores[i + 1];                        
                    }
                    fim--;
                    Console.WriteLine(">>> Atenção! Registro excluido com sucesso!! <<<");
                } 
                else
                {
                    Console.WriteLine("Posição "+ posicao +" fora da lista");
                }
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }
            finalizar();
        }
        
        public void Imprimir()
        {
            if (fim > 0)
            {
                Console.WriteLine("+--+----------------------------------");
                Console.WriteLine("| #| Descrição do Registro ");
                Console.WriteLine("+--+----------------------------------");                
                for (int i = 0; i < fim; i++)
                {
                    Console.WriteLine("| " + ( i + 1) + "|" + " " + valores[i]);
                }
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }                             
            Console.WriteLine("-------------------------------------");            
        }
        
        public void Imprimir(int posicao, int termino)
        {
            if (fim > 0)
            {               
                if ((posicao -1 < termino -1) && (posicao -1  >= inicio) && (termino -1 <= fim))
                {
                    Console.WriteLine("+--+----------------------------------");
                    Console.WriteLine("| #| Descrição do Registro ");
                    Console.WriteLine("+--+----------------------------------");
                    for (int i = (posicao -1) ; i <= (termino -1); i++)
                    {
                        Console.WriteLine("| " + (i + 1) + "|" + " " + valores[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Registros fora do limite");
                }
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }
            Console.WriteLine("-------------------------------------");
        }
        
        public void Ordenar()
        {
            if (fim > 0)
            {
                for (int i = 0; i < (fim-1); i++)
                {
                    for (int j = (i+1); j < fim; j++)
                    {
                         
                        if (valores[i].CompareTo(valores[j]) == 1)
                        {
                            string aux = valores[i];
                            valores[i] = valores[j];
                            valores[j] = aux;
                        }
                    }
                }
                Console.WriteLine(">>> Atenção! Classificação realizada com sucesso!! <<<");
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }
            finalizar();
        }
        
        public void Alterar(string valor, int posicao)
        {
            if (fim > 0)
            {
                if (posicao - 1 >= 0 && posicao - 1 < fim)
                {
                    valores[posicao-1] = valor;
                    Console.WriteLine(">>> Atenção! Nome alterado com sucesso!! <<<");                    
                }
                else
                {
                    Console.WriteLine(">>> Atenção! Não há informação na posição desejada <<<");
                }
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }
            finalizar();
        }
        
        public int Procurar(string valor)
        {
            int achou = 0;
            if (fim > 0)
            {
                for (int i = 0; i < fim; i++)
                {
                    if (valores[i].CompareTo(valor) == 0)
                    {                        
                        Console.WriteLine("Localizado na posição: " + (i + 1));
                        achou++;
                        finalizar();
                        return i;
                    }                    
                }                
            }
            else
            {
                Console.WriteLine(">>> Atenção! A lista está vazia <<<");
            }
            if (achou == 0)
            {
                Console.WriteLine("Nenhum registro localizado");
            }
            finalizar();
            return 0;
        }
    }
}
