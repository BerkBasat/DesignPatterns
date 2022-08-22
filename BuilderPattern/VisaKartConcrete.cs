using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class VisaKartConcrete : KrediKartiBuilder
    {
        public VisaKartConcrete()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Ziraat Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 15000;
        }

        public override void KartTip()
        {
            kart.KartTip = "Visa";
        }

        public override void Taksit()
        {
            kart.Taksit = false;
        }
    }
}
