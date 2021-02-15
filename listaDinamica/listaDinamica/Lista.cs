using System;

namespace listaDinamica
{
    class Lista
    {
        Noh inicio;
        Noh fim;
        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public void Inserir(string Valor) // metodo inserir em ordem de entrada de dados
        {
            Noh nn = new Noh(); // instância a classe noh que trata o dado e suas propriedades

            if (quantidade == 0)  // verifica se o dado entrado é o primeiro a entrar, para isso verifica se o contador
            {                     // de entrada de dados é igual a zero caso seja executa:
                nn.Valor = Valor; // atribui para novo noh instanciado o valor entrado Valor
                nn.Frente = null; // como é o primeiro atribui para propriedade frente valor nulo
                nn.Atras = null;  // se é o primeiro tbem é o único, portanto atribui propriedade atras valor nulo
                inicio = nn;      // a variável inicio recebe o novo noh, pq é o unico
                fim = nn;         // a variável fim tbem recebe o novo noh, pq é o unico
            }
            else                  // referece caso a verificação retorne o contador de entrada de dados maior que zero 
            {                     // executa a partir deste ponto, sendo que o primeiro já está registrado 
                nn.Valor = Valor; // atribui para novo noh instanciado o valor entrado Valor
                fim.Atras = nn;   // entra na propriedade atras do último 
                nn.Frente = fim;  // e na propriedade frente do novo noh coloque o último 
                nn.Atras = null;  // e na propriedade atras do novo noh coloque valor nulo, pois é o novo último  
                fim = nn;         // fim recebo novo noh e passa a ser o fim/último
            }
            quantidade++;         // contador de entrada de dados incrementa um             
        }

        public void Inserir(string Valor, int Posicao) // inserir na posição
        {
            Noh nn = new Noh(); // instância a classe noh que trata o dado e suas propriedades

            if (Posicao > quantidade) // testa se usuário passou uma posição maior que a quantidade
            {                         // dos elementos na fila, se verdadeiro, será direcionado ao metodo   
                Inserir(Valor);       // inserir que fara a inserção do novo valor na última posição da lista 
            }
            else // caso o teste retorne falso serão testados --***
            {
                if (Posicao <= 1) // se a posição desejada é a primeira caso seja verdadeiro
                {
                    nn.Valor = Valor;    // novo nó recebe o novo valor                   
                    nn.Frente = null;    // na frente do novo nó será nulo
                    nn.Atras = inicio;   // atrás do novo nó recebe o inicio
                    inicio.Frente = nn;  // o inicio recebe o novo nó na sua frente
                    inicio = nn;         // inicio recebe o novo nó, tornando-se o novo inicio da lista            
                }
                else // caso nenhum das outras possibilidades sejam verdadeiras e a inserção desejada
                {    // seja no meio da lista
                    Noh aux = inicio;       // cria-se uma auxiliar do tipo nó para receber o inicio da lista                                                        
                    for (int i = 1; i < Posicao; i++) // inicia-se um laço PARA de var(i=1 até a posição   
                    {                                 // passada pelo usuário) com incremento de um-em-um 
                        aux = aux.Atras;              // faz o mecanismo de movimento do ponteiro na estrutura
                    }                                 // movendo a auxiliar para trás um-em-um registro da lista 
                    nn.Valor = Valor;                 // até chegar na posição desejada-1. Novo nó recebe valor
                    nn.Atras = aux;                   // atrás do novo nó recebe auxiliar 
                    nn.Frente = aux.Frente;           // a frente do novo nó recebe propriedade da frente do auxiliar
                    aux.Frente.Atras = nn;            // atras do registro que está a frente do auxiliar recebe novo nó
                    aux.Frente = nn;                  // a frente do auxiliar recebe novo nó  
                }
                quantidade++;                         // --*** para ambos casos executados incrementar quantidade em 1.
            }            
        }

        /* Metodo excluir do professor 
         * 
         * public void Excluir()  
         * {
         *    if (ultimo.frente != null) // verifica na frente do ultimo elemento não for nulo
         *    {                          // caso seja vdd, entende-se que a lista está populada
         *       ultimo = ultimo.frente; // o ultimo elemento recebe o valor do elemento a sua frente
         *       ultimo.atras = null;    // atribui a propriedade atras do novo ultimo o valor nulo 
         *       quantidade--;           // decrementa-se a quantidade em 1 unidade. 
         *    }
         *    else                       // caso na frente do ultimo elemento seja nulo, entende-se 
         *    {                          // lista esta vazia
         *       Console.WriteLine("Lista vazia!");    // informa lista vazia ao usuário
         *       quantidade = 0;         // atribui-se ao contador de registros o valor zero 
         *       ultimo.atras = null;    // atribui a propriedade atras do novo ultimo o valor nulo
         *    }
         * }
         */

        public void Excluir_I()                       // metodo de exclusão no topo da lista, ou primeiro elemento da lista
        {
            if (quantidade > 0)                       // verifica se há itens na lista, caso vdd
            {
                inicio = inicio.Atras;                // atribui para inicio o elemento que está atras dele 
                inicio.Frente = null;                 // atribui para a propriedade Frente do inicio o valor nulo  
                quantidade--;                         // decrementa-se 1 unidade do contador quantidade 
            }
            else                                      // caso falso
            {
                Console.WriteLine("Lista vazia!");    // informa lista vazia ao usuário  
            }
        }

        public void Excluir_F()                       // metodo de exclusão no fim da lista, ou ultimo elemento da lista
        {
            if (quantidade > 0)                       // verifica se há itens na lista, caso vdd
            {
                fim = fim.Frente;                     // atribui para fim o elementro que está na Frente dele 
                fim.Atras = null;                     // atribui-se para a propriedade Atraz do fim o valor nulo  
                quantidade--;                         // decrementa-se 1 unidade do contador quantidade   
            }
            else                                      // caso falso 
            {
                Console.WriteLine("Lista vazia!");    // informa lista vazia ao usuário  
            }
        }

        public void Excluir(int Posicao)              // metodo de exclusão na Posição que o usuário escolher
        {
            if (Posicao >= quantidade)                // verifica se usuário passou posição maior ou igual a do ultimo elemento da lista 
            {                                         // caso vdd, será executado o metodo Excluir_F
                Excluir_F();
            }
            else if (Posicao <= 1)                    // verifica se usuário passou posição menor ou igual a do primeiro elemento da lista 
            {                                         // caso vdd, será executado o metodo Excluir_I
                Excluir_I();
            }
            else                                      // caso o usuário tenha passado valor no intervalo entre primeiro e ultimo elemento da lista  
            {
                Noh aux = inicio;                     // cria-se uma auxiliar do tipo nó para receber o inicio da lista
                for (int i = 1; i < Posicao; i++)     // inicia-se um laço PARA de var(i=1 até a posição passada pelo usuário) com incremento de   
                {                                     // um-em-um faz o mecanismo de movimento do ponteiro na estrutura da variavel auxiliar
                    aux = aux.Atras;                  // a cada vez que executa o laço auxiliar recebe o elemento que está atras dela.
                }

                aux.Frente.Atras = aux.Atras;        // atribui-se ao elemento da frente da posição desejada recebe ref elemento atras da posição
                aux.Atras.Frente = aux.Frente;       // atribui-se ao elemento de traz da posição desejada recebe ref elemento frente da posição
                quantidade--;                        // decrementa a quantidade                            
            }
        }
        
        public void Imprimir()                       // metodo de impressão da lista
        {
            if (quantidade > 0)                      // verifica se há itens na lista, caso vdd
            {
                Noh auxI = inicio;                   // cria-se uma auxiliar do tipo nó para receber o inicio da lista que recebe o primeiro elemeto
                                                     // da lista, ou o inicio da lista.
                Console.WriteLine("+-----------------------------------------+"); // layout tela de impressão 
                Console.WriteLine(" #            Descrição");                     // layout tela de impressão 

                for (int i = 1; i <= quantidade; i++)                             // inicia-se um laço PARA de variavel i = 1 enquanto i seja menor 
                {                                                                 // ou igual quantidade de registros
                    Console.WriteLine(" " + i + " " + auxI.Valor);                // imprime indice, e o valor guardado na posição que auxiliar recebeu
                    auxI = auxI.Atras;                                            // move o auxiliar para o elemento atres dele
                }
                Console.WriteLine("+-----------------------------------------+"); // layout tela de impressão 
            }
            else                                      // caso verificação retorne falso, ou seja não haja itens na lista 
            {
                Console.WriteLine("Lista vazia!");    // informa lista vazia ao usuário  
            }
            Console.ReadKey();                        // faz uma pausa para leitura da tela pelo usuário
            Console.Clear();                          // limpa tela
        }

        public void Alterar(string valor, string novoValor)
        {
            {
                if (quantidade > 0)                       // verifica se há itens na lista, caso vdd
                {
                    Noh auxI = inicio;                    // cria-se uma auxiliar do tipo nó para receber o inicio da lista que recebe o primeiro elemeto
                                                          // da lista, ou o inicio da lista.
                    int achou = 0;                        // variavel para retornar quantidade de correspondencias localizadas na lista
                    while (achou <= quantidade)
                    {
                        if (auxI.Valor == valor)          // verifica se auxiliar é igual ao valor(string) passado pelo usuário, caso vdd   
                        {
                            auxI.Valor = novoValor;
                            achou = quantidade;           // iguala o contador a quantidade, para realizar a parada do while 
                        }
                        auxI = auxI.Atras;
                        achou++;
                    }                    
                    Console.WriteLine("----------------------------------------------------"); // layout tela de impressão
                    Console.WriteLine("Alteração realizado com sucesso!");                     // informa quantidade de itens localizados na lista
                    Console.WriteLine("----------------------------------------------------"); // layout tela de impressão
                }
                else                                      // caso verificação retorne falso, ou seja não haja itens na lista  
                {
                    Console.WriteLine("Lista vazia!");    // informa lista vazia ao usuário
                }
                Console.ReadKey();                        // faz uma pausa para leitura da tela pelo usuário
                Console.Clear();                          // limpa tela
            }
        }

        public bool Procurar(string valor)
        {
            bool Achei = false;
            Noh auxP = inicio;
            while(Achei != true)
            {
                Achei = true;
            } 
            auxP = auxP.Atras;
            return Achei;
        }


        public void Pesquisar(string valor)           // metodo de pesquisa por item da lista 
        {
            if (quantidade > 0)                       // verifica se há itens na lista, caso vdd
            {
                Noh auxI = inicio;                    // cria-se uma auxiliar do tipo nó para receber o inicio da lista que recebe o primeiro elemeto
                                                      // da lista, ou o inicio da lista.
                int achou = 0;                        // variavel para retornar quantidade de correspondencias localizadas na lista
                for (int i = 1; i <= quantidade; i++) // inicia - se um laço PARA de variavel i = 1 enquanto i seja menor ou igual quantidade de registros
                {
                    if (auxI.Valor == valor)          // verifica se auxiliar é igual ao valor(string) passado pelo usuário, caso vdd   
                    {
                        Console.WriteLine("Localizado no indice " + i); // retorna ao usuário a msg localizado e o nr do elemento da lista ou seu indice 
                        achou++;                                        // incrementa da variavel de retorno das ocorrencias localizadas
                    }
                    auxI = auxI.Atras;                                  // move o auxiliar para o elemento atres dele
                }
                Console.WriteLine("----------------------------------------------------"); // layout tela de impressão
                Console.WriteLine("Resultado: " + achou + " correspondências locaizadas"); // informa quantidade de itens localizados na lista
                Console.WriteLine("----------------------------------------------------"); // layout tela de impressão
            }
            else                                      // caso verificação retorne falso, ou seja não haja itens na lista  
            {
                Console.WriteLine("Lista vazia!");    // informa lista vazia ao usuário
            }
            Console.ReadKey();                        // faz uma pausa para leitura da tela pelo usuário
            Console.Clear();                          // limpa tela
        }

        public void Ordenar(int Ordem = 0)
        {
            Noh ponteiro = inicio;
            Noh comparado = inicio.Atras;
            string aux = null;

            if (Ordem == 0)
            {
                for (int i = 1; i < quantidade; i++)
                {
                    for (int j = i+1; j <= quantidade; j++)
                    {
                        if (ponteiro.Valor.CompareTo(comparado.Valor) > 0)
                        {
                            aux = ponteiro.Valor;
                            ponteiro.Valor = comparado.Valor;
                            comparado.Valor = aux;
                        }
                        comparado = comparado.Atras;
                    }
                    ponteiro = ponteiro.Atras;
                    comparado = ponteiro.Atras;
                }
            }
            else
            {
                for (int i = 1; i < quantidade; i++)
                {
                    for (int j = i+1; j <= quantidade; j++)
                    {
                        if (ponteiro.Valor.CompareTo(comparado.Valor) < 0)
                        {
                            aux = ponteiro.Valor;
                            ponteiro.Valor = comparado.Valor;
                            comparado.Valor = aux;
                        }
                        comparado = comparado.Atras;
                    }
                    ponteiro = ponteiro.Atras;
                    comparado = ponteiro.Atras;
                }
            }
        }
    }
}