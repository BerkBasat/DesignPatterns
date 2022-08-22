using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class KrediKartiBuilder
    {

        //property
       protected KrediKarti kart;

       public KrediKarti Kart
        {
            get { return kart; }
        }


        //BankaAdi
        public abstract void BankaAdi();

        //KartTip
        public abstract void KartTip();

        //KartLimit
        public abstract void KartLimit();

        //Taksit
        public abstract void Taksit();
    }
}
