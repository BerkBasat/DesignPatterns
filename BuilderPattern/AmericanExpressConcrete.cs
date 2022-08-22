using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AmericanExpressConcrete : KrediKartiBuilder
    {
        public AmericanExpressConcrete()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 100000;
        }

        public override void KartTip()
        {
            kart.KartTip = "APEX";
        }

        public override void Taksit()
        {
            kart.Taksit = true;
        }
    }
}
