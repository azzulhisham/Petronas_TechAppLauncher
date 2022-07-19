using System.IO;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var data = new
{
    AppId = 157,
    AppType = "Plugin",
    PluginApp = "Petrel2019",
    AppUID = "NTD2020",
    Title = "GeoSenz NTD PETREL 2019",
    ShortDescription = "Tool that delineates the fracture connectivity in the seismic data",
    AppVersion = 1.0,
    InstallerUrl = "https://techupstream.petronas.com/tastore/AppVault/TechApps_NTD_Petrel_2019_20200903.zip",
    AppLogoUrl = new { Url = "https://techupstream.petronas.com/tastore/AppImage/NTD-logo.png" },
    Galleries = new string[] {
        "https://techupstream.petronas.com/tastore/AppImage/NTD-setting.PNG",
        "https://techupstream.petronas.com/tastore/AppImage/NTD-petrel.PNG"
    },
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
