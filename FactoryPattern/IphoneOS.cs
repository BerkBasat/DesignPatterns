﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class IphoneOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("bu uygulama iphone için çalışmaktadır");
        }
    }
}
