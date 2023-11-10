using MinimalApi.Enumerators;

namespace MinimalApi.Models;

public class TaskItemDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = default!;
    public DateTime DueDate { get; set; }
    public UserDto User { get; set; } = default!;
    public TaskItemStatus TaskItemStatus { get; set; }
}
