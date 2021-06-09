using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito
{
    abstract class HotdogDiszito : HotdogBase
    {
        private HotdogBase hotdogBase;

        public override string getHozzavalok()
        {
            return hotdogBase.getHozzavalok();
        }


        public override string getFogyasztas()
        {
            return hotdogBase.getFogyasztas();
        }


        public HotdogDiszito(HotdogBase hotdogBase)
        {
            this.hotdogBase = hotdogBase;
        }
    }
}
