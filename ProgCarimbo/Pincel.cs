using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    class Pincel
    {
        private int carga;
        private string cor;
        private string texto;
        private float diametroDaPonta;
        private int Tampa;

        public Pincel(string texto)
        {
            this.Texto = texto;
        }
        
        public string Texto
        {
            get{ return texto; }
            set{ texto = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public float DiametroDaPonta
        {
            get { return diametroDaPonta; }
            set { diametroDaPonta = value; }
        }

        public int TAMPA
        {
            get { return Tampa; }
            set { Tampa = value; }
        }

        public void destampar(int TAMPA)
        {
            if (TAMPA == 0)
            {
                Console.WriteLine("Já está destampado");
            }
            else
            {
                Console.WriteLine("Ok, o pincel foi tampado");
            }
        }

        public void tampar(int TAMPA)
        {
            if (TAMPA == 1)
            {
                Console.WriteLine("Ok, o pincel foi tampado");
            }
            else
            {
                Console.WriteLine("O pincel está destampando");
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
            if (TEXTO == Texto)
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
