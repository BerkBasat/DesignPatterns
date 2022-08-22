using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Builder tasarım deseni creational grubuna aittir. Builder tasarım deseninin esas amacı genişletilebilirliği sağlamak ve kod karmaşıklığını engellemektir. 
             */

            KrediKartiBuilder gercekKart = new MasterKartConcrete();

            KrediKartiKullan kullan = new KrediKartiKullan();


            //kullan.KartKullan(gercekKart);
            //Console.WriteLine(gercekKart.Kart.ToString());

            gercekKart = new AmericanExpressConcrete();
            kullan.KartKullan(gercekKart);
            Console.WriteLine(gercekKart.Kart.ToString());
            Console.ReadLine();
        }
    }
}
