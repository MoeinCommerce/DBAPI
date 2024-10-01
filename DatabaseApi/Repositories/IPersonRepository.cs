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
        void AddPersonPhoneNumber(int personId, List<PersonPhoneNumber> phoneNumbers);
        IEnumerable<Person> GetAll();
        IEnumerable<Person> GetWhere(Expression<Func<Person, bool>> predicate);
        Person GetPerson(int personId);
        IEnumerable<PersonPhoneNumber> GetPersonPhoneNumbers(int personId);
        IEnumerable<Person> GetPersonsByGroup(int groupId);
        void Update(Person person);
        void BulkUpdate(List<Person> persons);
        void Delete(int personId, bool forceDelete = false);
        void DeletePersonsByGroup(int groupId, bool forceDelete = false);
        void DeleteAll(bool forceDelete = false);
    }
}
