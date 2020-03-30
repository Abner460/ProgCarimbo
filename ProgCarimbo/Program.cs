using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCarimbo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carimbo Cr1 = new Carimbo("Animal");
            Cr1.carregar("vermelho", 6);
            Cr1.usar();

            Cr1.carregar("Azul", 3);
            Cr1.trocarCor("Azul");
            Cr1.trocarTexto("Baleia");

            Cr1.usar();

            Console.ReadKey();
        }
    }
}
