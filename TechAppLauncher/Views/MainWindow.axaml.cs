using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using TechAppLauncher.ViewModels;

namespace TechAppLauncher.Views
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.WhenActivated(d => d(ViewModel.CloseWin.Subscribe(Close)));
            this.WhenActivated(d => d(ViewModel.ShowAppDialog.RegisterHandler(DoShowAppDialogAsync)));
            this.WhenActivated(d => d(ViewModel.ShowMsgDialog.RegisterHandler(DoShowMsgDialogAsync)));
            this.WhenActivated(d => d(ViewModel.ShowRemoveAppDialog.RegisterHandler(DoShowRemoveAppDialogAsync)));

            this.Activated += (sender, e) =>
            {
                var context = this.DataContext as MainWindowViewModel;
                context.LoadXmlContent();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public async void OnDownloadAppClicked(object sender, RoutedEventArgs args)
        {
            OpenFolderDialog openFolderDialog = new OpenFolderDialog();
            string result = await openFolderDialog.ShowAsync(this);

            var context = this.DataContext as MainWindowViewModel;
           
            if (string.IsNullOrEmpty(result))
            {
                await context.RaiseMessage("Please select a folder from your system.");
                return;
            }

            context.DownloadAppPath = result;
            await context.DownloadApplication();
        }

        public async void OnInstallAppFromFileClicked(object sender, RoutedEventArgs args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string[] result = await openFileDialog.ShowAsync(this);
            var context = this.DataContext as MainWindowViewModel;

            if (result.Length == 0)
            {
                await context.RaiseMessage("Please select a downloaded Plugin from your system.");
                return;
            }

            if (string.IsNullOrEmpty(result[0]))
            {
                await context.RaiseMessage("Please select a downloaded Plugin from your system.");
                return;
            }

            context.InstallFromFile = result[0];
            await context.LaunchApplication(result[0]);
        }

        private async Task DoShowAppDialogAsync(InteractionContext<AppStoreViewModel, AppViewModel?> interaction)
        {
            var appStoreDialog = new AppStoreWindow();
            appStoreDialog.DataContext = interaction.Input;

            var result = await appStoreDialog.ShowDialog<AppViewModel?>(this);
            interaction.SetOutput(result);
        }

        private async Task DoShowMsgDialogAsync(InteractionContext<MessageDialogViewModel, MessageDialogViewModel> interaction)
        {
            var msgDialog = new MessageDialogView();
            msgDialog.DataContext = interaction.Input;

            var result = await msgDialog.ShowDialog<MessageDialogViewModel>(this);
            interaction.SetOutput(result);
        }

        private async Task DoShowRemoveAppDialogAsync(InteractionContext<RemoveAppViewModel, RemoveAppViewModel> interaction)
        {
            var rmvAppDialog = new RemoveAppView();
            rmvAppDialog.DataContext = interaction.Input;

            var result = await rmvAppDialog.ShowDialog<RemoveAppViewModel>(this);
            interaction.SetOutput(result);
        }
    }
}
