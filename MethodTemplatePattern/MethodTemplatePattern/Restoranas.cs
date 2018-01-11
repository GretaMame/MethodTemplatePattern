using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTemplatePattern
{
    class Restoranas
    {
        public Namas namas;

        public Restoranas(Namas namas)
        {
            this.namas = namas;
        }

        public void pastatytiRestorana()
        {
            namas.pastatytiNama();
        }
        
    }
}
