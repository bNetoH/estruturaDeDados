using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = DateTime.Now.Second;
            int m = DateTime.Now.Minute;
            int h = DateTime.Now.Hour;

            Imprimir(h, m, s);       
        }

        public static void Imprimir(int h, int m, int s)
        {
            Console.Clear();
            TimeSpan Agora = new TimeSpan(h, m, s);
            Console.Write("{0:c}", Agora);
            Segundo(h, m, s);
        }

        public static void Hora(int h, int m, int s)
        {
            if (h < 24)
            {
                Minuto(h, m = 0, s);
            }
            else
            {
                h = m = s = 0;
                Segundo(h, m, s);
            }
        }

        public static void Minuto(int h, int m, int s)
        {
            if (m < 60)
            {            
                Segundo(h, m, s = 0);
            }
            else
            {
                Hora(h += 1, m, s);
            }
        }

        public static void Segundo(int h, int m, int s)
        {
            if (s < 60)
            {
                int i = 0;
                do { i += 1; } while (i < 350000000);
                Imprimir(h, m, s += 1);                 
            }
            else
            {
                Minuto(h, m += 1, s);
            }
        }
    }
}