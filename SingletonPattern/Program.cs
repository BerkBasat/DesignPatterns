using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonNorthwind
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = DbTools.Northwind;

            foreach (var category in db.Categories.ToList())
            {
                Console.WriteLine(category.CategoryName);
            }
            Console.Read();
        }
    }
}
