using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarTempoEv
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

        private static void Imprimir(int h, int m, int s)
        {
            Console.Clear();
            TimeSpan Agora = new TimeSpan(h, m, s);
            Console.Write("{0:c}", Agora);
            SomarTempo(h, m, s);
        }

        private static void SomarTempo(int h, int m, int s)
        {
            if (s < 60)
            {
                int i = 0;
                do { i += 1; } while (i < 350000000);
                Imprimir(h, m, s += 1);
            }
            else
            {
                if (m < 60)
                {
                    SomarTempo(h, m += 1, s = 0);
                }
                else
                {
                    if (h < 24)
                    {
                        SomarTempo(h += 1, m = 0, s = 0);
                    }
                    else
                    {
                        SomarTempo(h = 0, m = 0, s = 0);
                    }
                }
            }            
        }
    }
}