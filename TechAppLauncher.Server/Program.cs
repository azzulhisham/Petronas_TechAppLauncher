using System.IO;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var data = new
{
    AppId = 184,
    AppType = "DSG",
    AppUID = "ENTDDSG2021",
    Title = "ENTD DSG",
    ShortDescription = "Enhanced Network Turtoisity Detection for DSG",
    AppVersion = 1.1,
    InstallerUrl = "/file",
};
var text = System.Text.Json.JsonSerializer.Serialize(data);

app.MapGet("/", () =>
{
    return Results.Content($"<pre>{text}</pre><a href='/install'>Install</a>", "text/html");
});

app.MapGet("/install", () =>
{
    return Results.File(Encoding.ASCII.GetBytes(text), "application/techapp", $"{data.AppUID}.techapp");
});

app.Run();
