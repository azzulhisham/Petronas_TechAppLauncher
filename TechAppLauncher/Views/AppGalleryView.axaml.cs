using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TechAppLauncher.Views
{
    public partial class AppGalleryView : UserControl
    {
        public AppGalleryView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
