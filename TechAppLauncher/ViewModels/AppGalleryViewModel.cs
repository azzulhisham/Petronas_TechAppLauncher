using ReactiveUI;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAppLauncher.Services;

namespace TechAppLauncher.ViewModels
{
    public class AppGalleryViewModel : ViewModelBase
    {
        private Bitmap _appImg;

        public Bitmap AppImg
        {
            get => _appImg;
            private set => this.RaiseAndSetIfChanged(ref _appImg, value);
        }

        private string _appImgUrl;

        public string AppImgUrl
        {
            get => _appImgUrl;
            private set => this.RaiseAndSetIfChanged(ref _appImgUrl, value);
        }


        public AppGalleryViewModel(string appImgUrl)
        {
            AppImgUrl = appImgUrl;
        }

        public async Task LoadAppImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(AppImgUrl))
                {
                    ITechAppStoreNetworkRequestService techAppStoreService = new TechAppStoreService();

                    await using (var imageStream = await techAppStoreService.LoadCoverBitmapAsync(AppImgUrl))
                    {
                        if (imageStream != null)
                        {
                            AppImg = await Task.Run(() => Bitmap.DecodeToWidth(imageStream, 800));
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
