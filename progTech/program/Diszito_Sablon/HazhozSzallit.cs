using progTech.Diszito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito_Sablon
{
    class HazhozSzallit : HotdogDiszito
    {
        public override string getFogyasztas()
        {
            return base.getFogyasztas() + " Házhozszállít";
        }

        public HazhozSzallit(HotdogBase hotdogBase) : base(hotdogBase)
        {

        }
    }
}
