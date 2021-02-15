namespace listaDinamica
{
    class Noh
    {        
        string valor;
        Noh frente;
        Noh atras;

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        internal Noh Frente
        {
            get
            {
                return frente;
            }

            set
            {
                frente = value;
            }
        }

        internal Noh Atras
        {
            get
            {
                return atras;
            }

            set
            {
                atras = value;
            }
        }
    }
}
