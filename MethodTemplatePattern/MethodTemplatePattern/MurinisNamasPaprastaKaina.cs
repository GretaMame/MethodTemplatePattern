using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplatePattern
{

    class MurinisNamasPaprastaKaina : Namas
    {
        private MurinisNamasHelper namas;
        private PaprastaKainaHelper kaina;

        public MurinisNamasPaprastaKaina(int trukme) : base(trukme)
        {
            namas = new MurinisNamasHelper();
            kaina = new PaprastaKainaHelper();
        }
        protected override string islietiPamatus()
        {
            return namas.islietiPamatus();
        }

        protected override string pastatytiSienas()
        {
            return namas.pastatytiSienas();
        }
        protected override string uzdengtiStoga()
        {
            return namas.uzdengtiStoga();
        }

        protected override float ivertintiKaina(int statymoTrukmeMenesiais)
        {
            return kaina.ivertintiKaina(statymoTrukmeMenesiais);
        }
    }
}
