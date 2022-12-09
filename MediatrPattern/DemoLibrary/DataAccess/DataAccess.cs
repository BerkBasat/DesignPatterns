using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<Person> people = new();

        public DataAccess()
        {
            people.Add(new Person { Id = 1, FirstName = "Berk", LastName = "Basat" });
        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public Person InsertPeople(string firstName, string lastName)
        {
            Person p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
