using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito
{
    class Ketchup : HotdogDiszito
    {
        public override string getHozzavalok()
        {
            return base.getHozzavalok() + " Ketchup";
        }

        public Ketchup(HotdogBase hotdogBase) : base(hotdogBase)
        {

        }
    }
}
