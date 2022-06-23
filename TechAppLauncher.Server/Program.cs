using System.IO;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var data = new
{
    AppId = 184,
    AppType = "DSG",
    AppUID = "ENTDDSG2021",
    Title = "ENTD DSG",
};
var text = System.Text.Json.JsonSerializer.Serialize(data);

app.MapGet("/", () =>
{
    return Results.Content($"<pre>{text}</pre><a href='/install'>Install</a>", "text/html");
});

app.MapGet("/install", () =>
{
    return Results.Content(text, "application/techapp");
});

app.Run();
