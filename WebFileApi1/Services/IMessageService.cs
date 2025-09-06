using WebFileApi1.Models.DTOs;

namespace WebFileApi1.Services;

public interface IMessageService
{
    Task<MessageReadDto> CreateMessageAsync(string message);
    Task<IEnumerable<MessageReadDto>> GetAllMessagesAsync();
    Task<MessageReadDto?> GetMessageByIdAsync(int id);
    Task<MessageReadDto?> UpdateMessageAsync(int id, string message);
    Task<bool> DeleteMessageAsync(int id);
}