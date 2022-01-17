using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TechAppLauncher
{
    public class Icons : Window
    {
        public Icons()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
