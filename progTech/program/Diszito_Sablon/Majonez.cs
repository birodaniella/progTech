using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito
{
    class Majonez : HotdogDiszito
    {
        public override string getHozzavalok()
        {
            return base.getHozzavalok() + " Majonéz";
        }

        public Majonez(HotdogBase hotdogBase) : base (hotdogBase)
        {

        }
    }
}
