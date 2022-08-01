using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;

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

var geo = new 
{
    AppId = 137,
    AppType = "Stand Alone",
    ReferenceId = "ScopeId_03A3D380-BC8F-4E85-8A80-23F2A423C8CF/Application_ceab5835-5987-46d1-a80d-fd5b6fe5f4f3",
    AppUID = "GeoSeisMod2019",
    Title = "GeoSeisMod",
    ShortDescription = "Geological Seismic Forward Modeling",
    AppVersion = 1.0,
    AppLogoUrl = new { Url = "https://techupstream.petronas.com/tastore/AppImage/geoseismod-logo.png" },
    Galleries = new string[] {
        "https://techupstream.petronas.com/tastore/AppImage/geoseismod-app.png",
    },
};

var text = JsonSerializer.Serialize(data);
var geoText = JsonSerializer.Serialize(geo);

app.MapGet("/", () => Results.Content(
    $"<pre>{text}</pre><a href='/plugin'>{data.Title}</a><br><pre>{geoText}</pre><a href='/standalone'>{geo.Title}</a>", "text/html"));

app.MapGet("/plugin", () => Results.File(Encoding.ASCII.GetBytes(text), "application/techapp", $"{data.AppUID}.techapp"));
app.MapGet("/standalone", () => Results.File(Encoding.ASCII.GetBytes(geoText), "application/techapp", $"{geo.AppUID}.techapp"));

app.Run();


