using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplatePattern
{
    abstract class Namas
    {
        private float kaina;
        protected int statymoTrukmeMenesiais;

        public Namas(int trukme)
        {
            statymoTrukmeMenesiais = trukme;
        }
        public void pastatytiNama()
        {
            Console.WriteLine( islietiPamatus());
            Console.WriteLine( pastatytiSienas());
            Console.WriteLine( uzdengtiStoga());
        }

        abstract protected string islietiPamatus();
        abstract protected string pastatytiSienas();
        abstract protected string uzdengtiStoga();

        public void gautiKaina()
        {
            kaina = ivertintiKaina(statymoTrukmeMenesiais);
            Console.WriteLine("Statymo kaina: {0}", kaina);
        }

        abstract protected float ivertintiKaina(int statymoTrukmeMenesiais);

    }
}
