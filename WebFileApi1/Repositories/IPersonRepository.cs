using WebFileApi1.Models;
using WebFileApi1.Models.DTOs;

namespace WebFileApi1.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> AddPersonAsync(PersonCreateDto person);
        Task<IEnumerable<Person>> GetAllPersonsAsync();
        Task<Person?> GetPersonByIdAsync(int id);
        Task<Person?> UpdatePersonAsync(Person person);
        Task<bool> DeletePersonAsync(int id);

    }
}