using ReactiveUI;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Input;
using static TechAppLauncher.Enums.MessageBoxStyle;

namespace TechAppLauncher.ViewModels
{
    public class MessageDialogViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, MessageDialogViewModel> CloseWin { get; }
        public ReactiveCommand<Unit, MessageDialogViewModel> ButtonYes { get; } 
        public ReactiveCommand<Unit, MessageDialogViewModel> ButtonNo { get; }

        private string _defaultButtonBackGroundColor = "White";
        private string _defaultButtonForeGroundColor = "Black";
        private string _defaultButtonBorderBrushColor = "Black";
        private string _defaultButtonBorderBrushThickness = "1";

        private string _buttonBackGroundColor = "Teal";
        private string _buttonForeGroundColor = "White";
        private string _buttonBorderBrushColor = "Teal";
        private string _buttonBorderBrushThickness = "0";


        private string _messageText;
        private string _windowColor = "WhiteSmoke";
        private Bitmap? _icoImg;

        private bool _isButtonYesNoVisible = false;
        private bool _isButton1Default = true;
        private bool _isButton2Default = false;

        private string _button1BackGround;
        private string _button1ForeGround;
        private string _Button1BorderBrush;
        private string _button1BorderThickness;

        private string _button2BackGround;
        private string _button2ForeGround;
        private string _Button2BorderBrush;
        private string _button2BorderThickness;


        public ButtonResult _buttonResult = ButtonResult.Closed;

        public ButtonResult ButtonResult
        {
            get => _buttonResult;
            set => this.RaiseAndSetIfChanged(ref _buttonResult, value);
        }

        public string Button1BackGround
        {
            get => _button1BackGround;
            set => this.RaiseAndSetIfChanged(ref _button1BackGround, value);
        }

        public string Button2BackGround
        {
            get => _button2BackGround;
            set => this.RaiseAndSetIfChanged(ref _button2BackGround, value);
        }

        public string Button1ForeGround
        {
            get => _button1ForeGround;
            set => this.RaiseAndSetIfChanged(ref _button1ForeGround, value);
        }

        public string Button2ForeGround
        {
            get => _button2ForeGround;
            set => this.RaiseAndSetIfChanged(ref _button2ForeGround, value);
        }

        public string Button1BorderBrush
        {
            get => _Button1BorderBrush;
            set => this.RaiseAndSetIfChanged(ref _Button1BorderBrush, value);
        }

        public string Button2BorderBrush
        {
            get => _Button2BorderBrush;
            set => this.RaiseAndSetIfChanged(ref _Button2BorderBrush, value);
        }

        public string Button1BorderThickness
        {
            get => _button1BorderThickness;
            set => this.RaiseAndSetIfChanged(ref _button1BorderThickness, value);
        }

        public string Button2BorderThickness
        {
            get => _button2BorderThickness;
            set => this.RaiseAndSetIfChanged(ref _button2BorderThickness, value);
        }

        public bool IsButtonYesNoVisible
        {
            get => _isButtonYesNoVisible;
            set => this.RaiseAndSetIfChanged(ref _isButtonYesNoVisible, value);
        }

        public bool IsButton1Default
        {
            get => _isButton1Default;
            set => this.RaiseAndSetIfChanged(ref _isButton1Default, value);
        }

        public bool IsButton2Default
        {
            get => _isButton2Default;
            set => this.RaiseAndSetIfChanged(ref _isButton2Default, value);
        }

        public MessageDialogViewModel()
        {
            CloseWin = ReactiveCommand.Create(() =>
            {
                ButtonResult = ButtonResult.Ok;
                return this;
            });
        }

        public MessageDialogViewModel(string messageText, IconStyle iconStyle, ButtonStyle buttonStyle = ButtonStyle.Ok, DefaultButton defaultButton = DefaultButton.Button1)
        {
            MessageText = messageText;
            WindowColor = "WhiteSmoke";

            this.Button1BackGround = this._defaultButtonBackGroundColor;
            this.Button1BorderBrush = this._defaultButtonBorderBrushColor;
            this.Button1BorderThickness = this._defaultButtonBorderBrushThickness;
            this.Button1ForeGround = this._defaultButtonForeGroundColor;

            this.Button2BackGround = this._buttonBackGroundColor;
            this.Button2BorderBrush = this._buttonBorderBrushColor;
            this.Button2BorderThickness = this._buttonBorderBrushThickness;
            this.Button2ForeGround = this._buttonForeGroundColor;

            this.IsButton1Default = true;
            this.IsButton2Default = false;

            IsButtonYesNoVisible = false;
            CloseWin = ReactiveCommand.Create(() =>
            {
                ButtonResult = ButtonResult.Ok;
                return this;
            });

            ButtonYes = ReactiveCommand.Create(() =>
            {
                ButtonResult = ButtonResult.Yes;
                return this;
            });

            ButtonNo = ReactiveCommand.Create(() =>
            {
                ButtonResult = ButtonResult.No;
                return this;
            });

            if (buttonStyle == ButtonStyle.YesNo)
            {
                IsButtonYesNoVisible = true;
            }

            if (defaultButton == DefaultButton.Button2)
            {
                this.Button2BackGround = this._defaultButtonBackGroundColor;
                this.Button2BorderBrush = this._defaultButtonBorderBrushColor;
                this.Button2BorderThickness = this._defaultButtonBorderBrushThickness;
                this.Button2ForeGround = this._defaultButtonForeGroundColor;

                this.Button1BackGround = this._buttonBackGroundColor;
                this.Button1BorderBrush = this._buttonBorderBrushColor;
                this.Button1BorderThickness = this._buttonBorderBrushThickness;
                this.Button1ForeGround = this._buttonForeGroundColor;

                this.IsButton1Default = false;
                this.IsButton2Default = true;
            }

            LoadAppImage(iconStyle);
        }

        public string MessageText
        {
            get => _messageText;
            set => this.RaiseAndSetIfChanged(ref _messageText, value);
        }

        public string WindowColor
        {
            get => _windowColor;
            set => this.RaiseAndSetIfChanged(ref _windowColor, value);
        }


        public Bitmap? IcoImg
        {
            get => _icoImg;
            private set => this.RaiseAndSetIfChanged(ref _icoImg, value);
        }

        public async Task LoadAppImage(IconStyle iconStyle)
        {
            string iconPath = "";

            if (iconStyle == IconStyle.Success)
            {
                iconPath = "success.png";
            }

            if (iconStyle == IconStyle.Error)
            {
                iconPath = "error.png";
            }

            if (iconStyle == IconStyle.Info)
            {
                iconPath = "info.png";
            }

            if (iconStyle == IconStyle.Warning)
            {
                iconPath = "warning.png";
            }

            try
            {
                await using (var imageStream = File.OpenRead(iconPath))
                {
                    if (imageStream != null)
                    {
                        IcoImg = await Task.Run(() => Bitmap.DecodeToWidth(imageStream, 400));
                    }
                }
            }
            catch (Exception dx)
            {

            }
        }

    }
}
