using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Namas namas1 = new MurinisNamasKainaSuNuolaida(20);
            Namas namas2 = new MedinisNamasPaprastaKaina(7);
            Restoranas restoranas = new Restoranas(new MedinisNamasKainaSuNuolaida(15));

            namas1.gautiKaina();
            namas1.pastatytiNama();
            Console.WriteLine();
            namas2.gautiKaina();
            namas2.pastatytiNama();
            Console.WriteLine();
            restoranas.pastatytiRestorana();

            Console.ReadLine();
        }
    }
}
