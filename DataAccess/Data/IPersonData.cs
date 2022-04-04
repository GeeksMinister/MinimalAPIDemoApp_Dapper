namespace DataAccess.Data;

public interface IPersonData
{
    Task DeletePerson(int id);
    Task<Person?> GetPerson(int id);
    Task<Person?> Search(string searchTerm);
    Task<IEnumerable<Person>> GetPeople();
    Task<Person> InsertPerson(Person person);
    Task UpdatePerson(Person person);
}