using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaRecursiva
{
    class Soma
    {
        double valor;
        int terminar;

        public double Valor
        {
            get { return valor; }
        }

        public int Terminar
        {
            get { return terminar; }
        }

        public void Somar(string ene)
        {
            if (ene != "")
            {
                valor += Convert.ToDouble(ene);
            }
            else
            {
                terminar++;
            }           
        }  
    }
}