using SideMenuDesign.Enums;
using System.Text;

namespace SideMenuDesign.Models;

public class UserDto
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public string Email { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public UserStatus UserStatus { get; set; } = UserStatus.Active;

    public string FullName()
    {
        var result = new StringBuilder(FirstName);

        if (!string.IsNullOrWhiteSpace(FirstName)) result.Append(" ");

        result.Append(LastName);

        return result.ToString();
    }
}
