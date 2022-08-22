using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class KrediKartiKullan
    {
        public void KartKullan(KrediKartiBuilder Kart)
        {
            Kart.BankaAdi();
            Kart.KartLimit();
            Kart.KartTip();
            Kart.Taksit();
        }
    }
}
