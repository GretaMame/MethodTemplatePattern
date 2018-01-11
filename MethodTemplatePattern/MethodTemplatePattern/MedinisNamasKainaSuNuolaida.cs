using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplatePattern
{
    class MedinisNamasKainaSuNuolaida : Namas
    {
        private MedinisNamasHelper namas;
        private KainaSuNuolaidaHelper kaina;

        public MedinisNamasKainaSuNuolaida(int trukme) : base(trukme)
        {
            namas = new MedinisNamasHelper();
            kaina = new KainaSuNuolaidaHelper();
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
