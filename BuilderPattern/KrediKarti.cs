using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTip { get; set; }
        public decimal KartLimit { get; set; }
        public bool Taksit{ get; set; }

        public override string ToString()
        {
            return "Banka: " + BankaAdi + " Kart Tip: " + KartTip + " Taksit: " + Taksit +" Kart Limit:" +KartLimit;
        }
    }
}
