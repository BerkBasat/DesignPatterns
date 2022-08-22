using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Factory
    {
        public MobileApplication FactoryMethod(MobileOs os)
        {
            MobileApplication ma = null;
            switch (os)
            {
                case MobileOs.IPhoneOs:
                    ma = new IphoneOS();
                    break;
                case MobileOs.WindowsOs:
                    ma = new WindowsOs();
                    break;
                case MobileOs.AndroidOs:
                    ma = new AndroidOs();
                    break;
               
            }
            return ma;
        }
    }
}
