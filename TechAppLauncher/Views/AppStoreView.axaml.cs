using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Reactive;
using TechAppLauncher.ViewModels;

namespace TechAppLauncher.Views
{
    public class AppStoreView : UserControl
    {
        public AppStoreView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public async void OnAppSelectionDoubleTapped(object sender, RoutedEventArgs args)
        {
            var appSelectCommandButton = this.FindControl<Button>("AppSelectCommandButton");

            Unit unit;
            appSelectCommandButton.Command.Execute(unit);
        }
    }
}
