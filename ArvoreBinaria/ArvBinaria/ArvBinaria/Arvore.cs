using System;

namespace ArvBinaria
{
    class Arvore
    {
        Noh raiz;
        Noh anterior;
        Noh atual;
        Noh pai;

        public void Criar()
        {
            if (raiz != null)
            {
                raiz = null;
            }
        }

        public void Inserir(int valor)
        {
            Noh nn = new Noh();

            if (raiz == null)
            {    
                nn.Valor = valor;
                nn.Esquerda = null;
                nn.Direita = null;
                raiz = nn;

                Console.WriteLine("Alocado na raiz Valor: " + 
                    nn.Valor);
            }
            else
            {
                atual = raiz;
                anterior = null;
                Procurar(atual, valor);
            }
        }

        public void Procurar(Noh atual, int valor)
        {

            anterior = atual;
            pai = anterior;
            if (valor < atual.Valor)
            {
                atual = atual.Esquerda;
            }
            else
            {
                atual = atual.Direita;
            }
            if (atual != null)
            {
                Procurar(atual, valor);
            }
            else
            {
                Noh nn = new Noh();
                int verificar = 0;

                if (valor < anterior.Valor)
                {
                    nn.Valor = valor;
                    nn.Esquerda = null;
                    nn.Direita = null;
                    anterior.Esquerda = nn;

                    if (pai != null)
                    {
                        verificar = pai.Valor;
                    }
                    Console.WriteLine("Alocado à Esq " + 
                        verificar + " Valor: " + nn.Valor);
                }
                else
                {
                    nn.Valor = valor;
                    nn.Esquerda = null;
                    nn.Direita = null;
                    anterior.Direita = nn;

                    if (pai != null)
                    {
                        verificar = pai.Valor;
                    }
                    Console.WriteLine("Alocado à Dir " + 
                        verificar + " Valor: " + nn.Valor);
                }
            }
        }
        // Modelos de percursos para busca/impressão
        // pré-ordem : raiz, nó esquerda, nó direita
        // em-ordem  : nó esquerda, raiz, nó direita 
        // pós-ordem : nó esquerda, nó direita, raiz
    }
}
