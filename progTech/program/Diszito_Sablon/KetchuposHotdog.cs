using progTech.Diszito_Sablon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito
{
    class KetchuposHotdog : HotdogKeszit
    {
        protected override void HolFogyaszt(string hol)
        {
            if(hol == "helyben")
            {
                HotdogBase h1 = new Hotdog();
                h1 = new HelybenFogyaszt(h1);
                Console.WriteLine(h1.getFogyasztas());
            }
            else
            {
                HotdogBase h1 = new Hotdog();
                h1 = new HazhozSzallit(h1);
                Console.WriteLine(h1.getFogyasztas());
            }
        }

        protected override void SzosztBelehelyez()
        {
            HotdogBase h1 = new Hotdog();
            h1 = new Ketchup(h1);
            Console.WriteLine(h1.getHozzavalok());
        }
    }
}
