using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            MobileApplication iphone = factory.FactoryMethod(MobileOs.IPhoneOs);
            MobileApplication android = factory.FactoryMethod(MobileOs.AndroidOs);
            MobileApplication windows = factory.FactoryMethod(MobileOs.WindowsOs);

            android.Platform();
            iphone.Platform();
            windows.Platform();

            Console.Read();
        }
    }
}
