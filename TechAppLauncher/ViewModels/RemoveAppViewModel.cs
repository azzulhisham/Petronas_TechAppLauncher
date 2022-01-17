using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TechAppLauncher.Services;

namespace TechAppLauncher.ViewModels
{
    public class RemoveAppViewModel : ReactiveObject
    {
        public ReactiveCommand<Unit, Unit> RemoveApp { get; }
        public ReactiveCommand<Unit, RemoveAppViewModel> CloseWin { get; }
        public Interaction<MessageDialogViewModel, MessageDialogViewModel> ShowMsgDialog { get; }

        public ObservableCollection<string> ItemsInSystem { get; } = new();

        private IXmlDocService _xmlDocService;
        
        private string _selectedItem = "";
        private string _preSelectedItem = "";

        public string SelectedItem
        {
            get => _selectedItem;
            set => this.RaiseAndSetIfChanged(ref _selectedItem, value);
        }

        public RemoveAppViewModel(string preSelectedItem = null)
        {
            this._preSelectedItem = preSelectedItem;

            _xmlDocService = new XmlDocService();
            ShowMsgDialog = new Interaction<MessageDialogViewModel, MessageDialogViewModel>();

            CloseWin = ReactiveCommand.Create(() =>
            {
                return this;
            });

            RemoveApp = ReactiveCommand.CreateFromTask(async () =>
            {
                var removeIndex = ItemsInSystem.IndexOf(SelectedItem);

                if (removeIndex < 0)
                {
                    string messageBoxText = "Please select an app in order to start uninstalling.";
                    var messageBoxDialog = new MessageDialogViewModel(messageBoxText, Enums.MessageBoxStyle.IconStyle.Info);
                    var result = await ShowMsgDialog.Handle(messageBoxDialog);
                }
                else
                {
                    string messageBoxText = "Are you sure you want to uninstall this app?";
                    var messageBoxDialog = new MessageDialogViewModel(messageBoxText, Enums.MessageBoxStyle.IconStyle.Warning, Enums.MessageBoxStyle.ButtonStyle.YesNo, Enums.MessageBoxStyle.DefaultButton.Button2);
                    var result = await ShowMsgDialog.Handle(messageBoxDialog);

                    if (result != null && result.ButtonResult == Enums.MessageBoxStyle.ButtonResult.Yes)
                    {
                        _xmlDocService.XmlRemoveItem(removeIndex);
                        ItemsInSystem.Remove(SelectedItem);

                        LoadXmlContent();
                    }
                }
            });

            LoadXmlContent();
        }

        private void LoadXmlContent() 
        {         
            var result = _xmlDocService.XmlLoad(ItemsInSystem);

            if (!string.IsNullOrEmpty(this._preSelectedItem))
            {
                SelectedItem = this._preSelectedItem;
                this._preSelectedItem = "";
            }
        }
    }
}
