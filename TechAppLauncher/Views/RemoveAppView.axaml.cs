using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using System.Threading.Tasks;
using TechAppLauncher.ViewModels;

namespace TechAppLauncher.Views
{
    public partial class RemoveAppView : ReactiveWindow<RemoveAppViewModel>
    {
        public RemoveAppView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.WhenActivated(d => d(ViewModel.CloseWin.Subscribe(Close)));
            this.WhenActivated(d => d(ViewModel.ShowMsgDialog.RegisterHandler(DoShowMsgDialogAsync)));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async Task DoShowMsgDialogAsync(InteractionContext<MessageDialogViewModel, MessageDialogViewModel> interaction)
        {
            var msgDialog = new MessageDialogView();
            msgDialog.DataContext = interaction.Input;

            var result = await msgDialog.ShowDialog<MessageDialogViewModel>(this);
            interaction.SetOutput(result);
        }
    }
}
