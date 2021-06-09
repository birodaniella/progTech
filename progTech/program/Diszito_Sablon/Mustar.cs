using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito
{
    class Mustar : HotdogDiszito
    {
        public override string getHozzavalok()
        {
            return base.getHozzavalok() + " Mustár";
        }

        public Mustar(HotdogBase hotdogBase) : base(hotdogBase)
        {

        }
    }
}
