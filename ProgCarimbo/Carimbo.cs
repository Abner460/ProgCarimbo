using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    class Carimbo : Interacao
    {
        private string cor;
        private string texto;
        private int carga;

        public Carimbo(string texto)
        {
            this.Texto = texto;
        }
        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public void usar()
        {
            if (Carga >= 1)
            {
                if (!string.IsNullOrEmpty(Texto))
                {
                    if (!string.IsNullOrEmpty(Cor))
                    {
                        Console.WriteLine("O texto " + Texto + " está na cor " + Cor);
                        Carga--;
                    }
                    else
                    {
                        Console.WriteLine("Impossível carimbar - Carimbo está sem cor");
                    }
                }
                else
                {
                    Console.WriteLine("Impossível carimbar - Carimbo está sem texto");
                }
            }
            else
            {
                Console.WriteLine("Impossível Carimbar - Carimbo está sem carga");
            }

        }

        public void carregar(string COR, int CARGA)
        {
            trocarCor(COR);

            if ((CARGA >= 1 && CARGA <= 10) && ((CARGA + Carga) <= 10))
            {
                Carga = CARGA;
            }
            else
            {
                Console.WriteLine("Carga atual: " + Carga + " mais a carga deve ser entre 1 e 10");
            }
        }

        public void trocarCor(string COR)
        {
            if (COR == Cor)
            {
                Console.WriteLine("Ok, carimbo já está nesta cor");
            }
            else
            {
                Cor = COR;
            }
        }

        public void trocarTexto(string TEXTO)
        {
            if(TEXTO == Texto)
            {
                Console.WriteLine("Ok, O carimbo já contém esse texto");
            }
            else
            {
                Texto = TEXTO;
            }
        }

    }
}