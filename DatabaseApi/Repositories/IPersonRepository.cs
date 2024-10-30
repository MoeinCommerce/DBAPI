using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IPersonRepository
    {
        void Add(Person person);
        void AddRange(IEnumerable<Person> persons);
        //void AddPersonPhoneNumber(int personId, List<PersonPhoneNumber> phoneNumbers);
        IEnumerable<Person> GetAll();
        Person GetPerson(int personId);
        //IEnumerable<PersonPhoneNumber> GetPersonPhoneNumbers(int personId);
        IEnumerable<Person> GetPersonsByGroup(int groupId);
        void Update(Person person);
        void BulkUpdate(List<Person> persons);
        void Delete(int personId);
        void DeleteCasecade(int personId);
        IEnumerable<Person> Search(string text);
        IEnumerable<Person> SearchByName(string text);
        IEnumerable<Person> SearchByCode(string text);
        IEnumerable<Person> SearchByLastName(string text);
        IEnumerable<Person> SearchByCompanyName(string text);
        IEnumerable<Person> SearchByPhoneNumber(string text);
        IEnumerable<Person> SearchByAddress(string text);

    }
}
