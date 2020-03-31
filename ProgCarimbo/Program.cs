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
            Cr1.carimbar();

            Cr1.carregar("Azul", 3);
            Cr1.trocarCor("Azul");
            Cr1.trocarTexto("Baleia");

            Cr1.carimbar();

            int p1opcao;

            Pincel p1 = new Pincel("Colorir");
            p1.trocarCor("Amarelo");

            Console.WriteLine("Para destampar o pinciel digite 0");
            p1opcao = int.Parse(Console.ReadLine());
            p1.destampar(p1opcao);

            Console.WriteLine("Para tampar o pincel digite 1");
            p1opcao = int.Parse(Console.ReadLine());
            p1.tampar(p1opcao);


            Console.ReadKey();
        }
    }
}
