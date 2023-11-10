using System.Text;
using MinimalApi.Enumerators;

namespace MinimalApi.Models;

public class UserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public UserStatus UserStatus { get; set; } = UserStatus.Active;
    
    public string FullName()
    {
        var result = new StringBuilder(FirstName);

        if (!string.IsNullOrWhiteSpace(FirstName)) result.Append(" ");

        result.Append(LastName);

        return result.ToString();
    }
}
