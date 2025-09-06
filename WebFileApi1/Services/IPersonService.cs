using WebFileApi1.Models.DTOs;

namespace WebFileApi1.Services
{
    public interface IPersonService
    {
        Task<PersonReadDto> CreatePersonAsync(PersonCreateDto person);
        Task<IEnumerable<PersonReadDto>> GetAllPersonsAsync();
        Task<PersonReadDto?> GetPersonByIdAsync(int id);
        Task<PersonReadDto?> UpdatePersonAsync(int id, PersonUpdateDto person);
        Task<bool> DeletePersonAsync(int id);
    }
}