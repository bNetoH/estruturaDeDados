/* Classe fila
 * 
 * vetor 5 posições >>> ilustrado por cadeiras.
 * 
 * os dados inseriods no vetor serão encadeador de forma ordinal crescente sendo o 
 * primeiro a entrar = próximo a ser atendido. 
 * Como na fila estática o após o primeiro registro, o ultimo será alocado nas vagas do vetor 
 * isso enquanto o ultimo for < limite, caso seja maior o usuario recebera o aviso 
 * "não há cadeiras vazias"
 * Quando o usuário chamar o próximo (excluisão) o segundo na fila será realocado da sua posição
 * para a posição do primeiro, movendo dos dados no vetor para a nova posição, o terceiro
 * na fila será realocado da sua posição para a posição do segundo, movendo dados no vetor 
 * para a nova posição e assim por diante, realocando todas as informações para uma posição anterior
 * a sua atual até o último. Após essa operação de mover os dados no vetor, o ultimo será 
 * decrementado em 1 deixando 1 posição(a ultima cadeira) vaga, possibilitando a inserção de um novo
 * registro que assumirá a posição do último. 
 * Impressão da lista: fica limitada a imprimir até o ultimo e não ao limite, pois a lista pode
 * estar com menos ocupantes que o seu limite de 5.   
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaCircular
{
    class fila
    {
        int limite, primeiro, ultimo;
        string[] valores;

        public fila(int Tamanho)
        {
            valores = new string[Tamanho];
            primeiro = ultimo = -1;
            limite = Tamanho - 1;
        }
        
        public void Acomodar(string valor)
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
                Console.WriteLine(">>> Não há cadeiras vagas <<<");
            }
        }
        
        public void Chamar()
        {
            if (primeiro <= ultimo)
            {
                Console.WriteLine(">>> Próximo : " + valores[primeiro]);

                for (int i = 1; i <= limite; i++)
                {
                    valores[(i - 1)] = valores[i];
                }
                ultimo--;
            }
            else
            {
                Console.WriteLine(">>> Cadeiras estão vagas <<<<");
            }
        }

        public void Imprimir()
        {
            if (primeiro <= ultimo)
            {
                for (int i = 0; i <= ultimo; i++)
                {                    
                    Console.WriteLine((i+1)+"º da fila: " + valores[i]);
                }
            }
            else
            {
                Console.WriteLine(">>> Cadeiras estão vagas <<<");
            }
        }
    }
}