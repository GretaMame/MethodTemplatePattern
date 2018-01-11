using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplatePattern
{
    class KainaSuNuolaidaHelper
    {
        public float ivertintiKaina(int trukmeMenesiais)
        {
            if (trukmeMenesiais < 10)
            {
                return trukmeMenesiais * 70000 * 0.9F;
            }
            else return 5000 * trukmeMenesiais * 0.9F;
        }
    }
}
