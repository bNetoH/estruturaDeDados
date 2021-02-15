using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamica
{
    class NOH
    {
        string valor;
        NOH anterior;

        public string Valor
        {
            // poderia declarar apenas | get; set; | porém para ter maior controle 
            // sobre o conteudo armazenado exemplo no pegar
            get { return valor; }
            set { if (value !="") { valor = value; } }
        }

        public NOH Anterior
        {            
            get { return anterior; }
            set { anterior = value; }            
        }
    }
}