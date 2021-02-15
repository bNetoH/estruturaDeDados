namespace ArvBinaria
{
    class Noh
    {
        int valor = 0;
        Noh direita = null;
        Noh esquerda = null;

        public int Valor
        {
            get {return valor;}
            set {valor = value;}
        }

        internal Noh Direita
        {
            get {return direita;}
            set {direita = value;}
        }

        internal Noh Esquerda
        {
            get {return esquerda;}

            set {esquerda = value;}
        }
    }
}