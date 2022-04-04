using DataAccess.DbAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class PersonData : IPersonData
{
    private readonly ISqlDataAccess _db;

    public PersonData(ISqlDataAccess db)
    {
        _db = db;
    }
    public async Task<IEnumerable<Person>> GetPeople() =>
        await _db.LoadData<Person, dynamic>("dbo.spPerson_GetAll", new { });

    public async Task<Person?> GetPerson(int id)
    {
        var result = await _db.LoadData<Person, dynamic>("dbo.spPerson_Get", new { Id = id });
        return result.FirstOrDefault();

    }

    public async Task<Person> InsertPerson(Person Person)
    {
         var result = await _db.LoadData<Person, dynamic>("dbo.spPerson_Insert", new
        {
            Person.FirstName,
            Person.LastName,
            Person.Age,
            Person.Phone,
            Person.Email,
            Person.City
        });
#pragma warning disable CS8603
        return result.FirstOrDefault();
    }

    public async Task<Person?> Search(string searchTerm)
    {
        var result =  await _db.LoadData<Person, dynamic>("dbo.spPerson_Search", new { searchTerm = searchTerm });
        return result.FirstOrDefault();
    }

    public Task UpdatePerson(Person Person) => _db.SaveData("dbo.spPerson_Update", Person);

    public Task DeletePerson(int id) => _db.SaveData("dbo.spPerson_Delete", new { Id = id });
}
