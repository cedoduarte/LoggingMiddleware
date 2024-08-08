using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPersonService
    {
        Task<Person?> GetPersonById(int id);
        Task<List<Person>> GetPersons();
    }

    public class PersonService : IPersonService
    {
        private List<Person> _persons = new() 
        {
            new Person()
            {
                Id=  1,
                FirstName = "Carlos",
                LastName = "Duarte",
                Age = 29
            },
            new Person()
            {
                Id= 2,
                FirstName = "Ana",
                LastName = "Lopez",
                Age = 29
            },
            new Person()
            {
                Id= 3,
                FirstName = "Luis",
                LastName = "Rodriguez",
                Age = 29
            }
        };

        public async Task<Person?> GetPersonById(int id)
        {
            foreach (Person person in _persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return null;
        }

        public async Task<List<Person>> GetPersons()
        {
            return _persons;
        }
    }
}
