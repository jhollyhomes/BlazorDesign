using Bogus;
using MinimalApi.Enumerators;
using MinimalApi.Models;

namespace MinimalApi.FakeData;

public static class DataCreator
{
    private static Faker<UserDto> GetUsersGenerator()
    {
        var id = 1;

        return new Faker<UserDto>()
            .StrictMode(false)
            .RuleFor(c => c.Id, _ => id++)
            .RuleFor(c => c.FirstName, f => f.Person.FirstName)
            .RuleFor(c => c.LastName, f => f.Person.LastName)
            .RuleFor(c => c.Email, f => f.Person.Email)
            .RuleFor(c => c.UserStatus, f => f.PickRandom<UserStatus>());
    }

    public static IQueryable<TaskItemDto> GetTasks(int numberOfTasks = 1742)
    {
        var generatedUsers = GetUsersGenerator().Generate(30);

        var taskGenerator = GetTasksGenerator(generatedUsers);
        var generatedTasks = taskGenerator.Generate(numberOfTasks);

        return generatedTasks.AsQueryable();
    }

    private static Faker<TaskItemDto> GetTasksGenerator(List<UserDto> users)
    {
        var id = 1;

        return new Faker<TaskItemDto>()
            .StrictMode(false)
            .RuleFor(c => c.Id, _ => id++)
            .RuleFor(c => c.Title, f => f.Commerce.ProductDescription())
            .RuleFor(c => c.User, f => f.PickRandom(users))
            .RuleFor(c => c.DueDate, f => f.Date.Future(1))
            .RuleFor(c => c.TaskItemStatus, f => f.PickRandom<TaskItemStatus>());
    }
}
