using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaEstatica
{
    class fila // nome da classe
    {
        int limite, primeiro, ultimo;   
        string[] valores;

        public fila(int Tamanho)
        {
            valores = new string[Tamanho];
            primeiro = ultimo = -1;
            limite = Tamanho-1;
        }

        public void Enfileirar(string valor)
        {
            if (ultimo < limite)
            {
                if (primeiro == -1)
                {
                    primeiro++;
                    ultimo++;
                    valores[ultimo] = valor;
                }
                else
                {
                    ultimo++;
                    valores[ultimo] = valor;
                }
            }
            else
            {
                Console.WriteLine("Fila está cheia");
            }
        }

        public void Desenfileirar()
        {
            if (primeiro <= ultimo)
            {
                primeiro++;
            }
            else
            {
                Console.WriteLine("Fila está vazia");
            }
        }

        public void Imprimir()
        {
            if (primeiro <= ultimo)
            {
                for (int i = primeiro; i <= ultimo; i++)
                {
                    Console.WriteLine(valores[i]);
                }
            }
            else
            {
                Console.WriteLine("Fila está vazia");
            }
        }
    }
}
