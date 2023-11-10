using MinimalApi.FakeData;
using MinimalApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(c => c.AddPolicy("MinimalApi", p => p
                .AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

app.UseCors("MinimalApi");

app.UseHttpsRedirection();

var tasks = DataCreator.GetTasks();

app.MapGet("/api/tasks", (int pn, int ps, string sf, string so, string? s) =>
{
    var query = tasks.OrderByDynamic(sf, so.ToUpper());

    if (!string.IsNullOrWhiteSpace(s)) query = query.Where(x => x.Title.Contains(s));

    var itemCount = query.Count();
    var items = query.Skip((pn - 1) * ps)
                     .Take(ps)
                     .ToList();

    return Results.Ok(new { data = items, count = itemCount });
});

app.Run();