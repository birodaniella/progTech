using progTech.Diszito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progTech
{
    class Program
    {
        static void Main(string[] args)
        {
            //HotdogBase h1 = new Hotdog();
            //h1 = new Majonez(h1);
            //h1 = new Ketchup(h1);

            //Console.WriteLine(h1.getHozzavalok());

            //HotdogKeszit majonezes = new MajonezesHotdog();
            //majonezes.Elkeszit();

            Console.WriteLine("Kérem adja meg annak a sorszámát, amilyen hot dogot rendelni szeretne az alábbiak közül: ");
            Console.WriteLine(" 1.) Ketchupos hot dog \n 2.) Majonézes hot dog \n 3.) Mustáros hot dog \n 4.) Teljes hot dog (mind a három szószt tartalmazza)");

            string sorszam = Console.ReadLine();

            Console.WriteLine("Kérem adja meg annak a sorszámát, hogy helyben szeretné fogyasztani vagy házhozszállítva kéri: ");
            Console.WriteLine(" 1.) Helyben fogyaszt \n 2.) Házhozszállítva kérem");

            string holFogyaszt;

            if(Console.ReadLine() == "1")
            {
                holFogyaszt = "helyben";
            }
            else
            {
                holFogyaszt = "";
            }

            switch (sorszam)
            {
                case "1":
                    Console.WriteLine("A választott hot dog: Ketchupos");
                    HotdogKeszit ketchup = new KetchuposHotdog();
                    ketchup.Elkeszit(holFogyaszt);

                    break;
                case "2":
                    Console.WriteLine("A választott hot dog: Majonéz");
                    HotdogKeszit majonezes = new MajonezesHotdog();
                    majonezes.Elkeszit(holFogyaszt);

                    break;
                case "3":
                    Console.WriteLine("A választott hot dog: Mustár");
                    HotdogKeszit mustaros = new MustarosHotdog();
                    mustaros.Elkeszit(holFogyaszt);

                    break;
                case "4":
                    Console.WriteLine("A választott hot dog: Teljes");
                    HotdogKeszit teljes = new TeljesHotdog();
                    teljes.Elkeszit(holFogyaszt);

                    break;
                default:
                    Console.WriteLine("Hibás sorszám");
                    break;
            }

            //HotdogKeszit ketchup = new KetchuposHotdog();
            //ketchup.Elkeszit("");

            Console.ReadLine();

        }
    }
}
