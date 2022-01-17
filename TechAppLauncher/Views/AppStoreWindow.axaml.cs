using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using TechAppLauncher.ViewModels;

namespace TechAppLauncher.Views
{
    public class AppStoreWindow : ReactiveWindow<AppStoreViewModel>
    {
        public AppStoreWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.WhenActivated(d => d(ViewModel.GetAppSelectCommand.Subscribe(Close)));

            this.WhenActivated(d => d(ViewModel.GetAppSelectCommandClose.Subscribe(Close)));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
