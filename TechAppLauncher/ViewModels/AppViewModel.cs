using ReactiveUI;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAppLauncher.Models;
using TechAppLauncher.Services;

namespace TechAppLauncher.ViewModels
{
    public class AppViewModel : ViewModelBase
    {
        private readonly Models.App _app;

        public AppViewModel(Models.App app)
        {
            _app = app;
        }

        public string Description => _app.ShortDescription;

        public string Title => _app.Title;

        public string AppGroup => _app.AppGroup;

        public int AppId => _app.ID;

        public string AppUID => _app.AppUID;
        public string AppType => _app.AppType;
        public string PluginApp => _app.PluginApp;

        public double? AppVersion => _app.AppVersion;

        private Bitmap? _appImg;

        public Bitmap? AppImg
        {
            get => _appImg;
            private set => this.RaiseAndSetIfChanged(ref _appImg, value);
        }

        public async Task LoadAppImage()
        {
            try
            {
                if (_app.AppLogoUrl != null)
                {
                    await using (var imageStream = await new TechAppStoreService().LoadCoverBitmapAsync(_app.AppLogoUrl.Url))
                    {
                        if (imageStream != null)
                        {
                            AppImg = await Task.Run(() => Bitmap.DecodeToWidth(imageStream, 400));
                        }
                    }
                }
            }
            catch (Exception dx)
            {

            }
        }
    }
}
