using progTech.Diszito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito_Sablon
{
    class HelybenFogyaszt : HotdogDiszito
    {
        public override string getFogyasztas()
        {
            return base.getFogyasztas() + " Helyben fogyaszt";
        }

        public HelybenFogyaszt(HotdogBase hotdogBase) : base(hotdogBase)
        {

        }
    }
}
