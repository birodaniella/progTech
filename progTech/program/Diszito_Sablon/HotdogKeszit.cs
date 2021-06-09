using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech.Diszito
{
    abstract class HotdogKeszit
    {

        public void Elkeszit(string holFogyaszt)
        {
            KiflitSut();
            VirslitBelehelyez();
            SzosztBelehelyez();
            HolFogyaszt(holFogyaszt);
        }

        private void KiflitSut()
        {
            Console.WriteLine("Kifli sütése");
        }

        private void VirslitBelehelyez()
        {
            Console.WriteLine("Virsli belerakása");
        }

        protected abstract void SzosztBelehelyez();
        protected abstract void HolFogyaszt(string hol);
       

    }
}
