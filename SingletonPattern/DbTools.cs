using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonNorthwind
{
    public class DbTools
    {
        private DbTools()
        {

        }

        private static NorthwindEntities _northWind;

        public static NorthwindEntities Northwind
        {
            get
            {
                if (_northWind == null)
                {
                    _northWind = new NorthwindEntities();
                }
                return _northWind;
            }
        }
    }
}
