using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using System.Reactive;
using System.Threading.Tasks;
using TechAppLauncher.ViewModels;

namespace TechAppLauncher.Views
{
    public partial class MessageDialogView : ReactiveWindow<MessageDialogViewModel>
    {
        public MessageDialogView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.WhenActivated(d => d(ViewModel.CloseWin.Subscribe(Close)));
            this.WhenActivated(d => d(ViewModel.ButtonYes.Subscribe(Close)));
            this.WhenActivated(d => d(ViewModel.ButtonNo.Subscribe(Close)));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
