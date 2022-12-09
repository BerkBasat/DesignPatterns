using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<Person> GetPeople();
        Person InsertPeople(string firstName, string lastName);
    }
}