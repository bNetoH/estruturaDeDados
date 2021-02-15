using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaDinamica
{
    class Noh
    {
        string valor;
        Noh anterior;
        Noh posterior;

        public string Valor { get; set; }  // conteudo que será guardado em valor
        public Noh Anterior { get; set; }  // conteudo que estará na frente valor
        public Noh Posterior { get; set; } // conteudo que estará atrás valor

        /* GET-SET  pode ser definido contemplando algumas verificações condicional
         * para a execução do método. conforme exemplos abaixo:
         *                           
        public string Valor
        {
            // poderia declarar apenas | get; set; | porém para ter maior controle 
            // sobre o conteudo armazenado exemplo no pegar
            get { return valor; }
            set { if (value != "") { valor = value; } }
        }

        public Noh Posterior
        {
            get { return posterior; }
            set { posterior = value; }
        }

        public Noh Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }*/

    }
}
