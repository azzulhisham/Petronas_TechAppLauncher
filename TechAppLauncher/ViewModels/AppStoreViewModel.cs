using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechAppLauncher.Services;

namespace TechAppLauncher.ViewModels
{
    public class AppStoreViewModel: ViewModelBase
    {
        private AppViewModel? _selectedApp;
        private CancellationTokenSource? _cancellationTokenSource;
        
        private bool _isLaunchAble;
        private bool _isBusy;
        private bool _isSearchAble;

        private string _appTitleBar;

        private string? _searchText;
        private IList<Models.App> _apps;

        public ObservableCollection<AppViewModel> SelectedResults { get; } = new();
        public ReactiveCommand<Unit, AppViewModel?> GetAppSelectCommand { get; }
        public ReactiveCommand<Unit, AppViewModel?> GetAppSelectCommandClose { get; }

        public string AppTitleBar
        {
            get => _appTitleBar;
            set => this.RaiseAndSetIfChanged(ref _appTitleBar, value);
        }

        public AppViewModel? SelectedApp
        {
            get => _selectedApp;
            set 
            {
                this.IsLaunchAble = true;
                this.RaiseAndSetIfChanged(ref _selectedApp, value);
            }
        }

        public bool IsLaunchAble
        {
            get => _isLaunchAble;
            set => this.RaiseAndSetIfChanged(ref _isLaunchAble, value);
        }

        public bool IsSearchAble
        {
            get => _isSearchAble;
            set => this.RaiseAndSetIfChanged(ref _isSearchAble, value);
        }

        public string? SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }

        public AppStoreViewModel()
        {
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            AppTitleBar = $"Tech App Store - Ver. : {assemblyVersion.Major}.{assemblyVersion.MajorRevision}.{assemblyVersion.Build}.{assemblyVersion.Revision}";

            this.WhenAnyValue(x => x.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(400))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(DoSearch!);


            GetAppSelectCommand = ReactiveCommand.Create(() =>
            {
                return SelectedApp;
            });

            GetAppSelectCommandClose = ReactiveCommand.Create(() =>
            {
                SelectedApp = null;
                return SelectedApp;
            });

            ListAllApp();
        }


        private async void DoSearch(string s)
        {
            if (_apps == null)
            {
                return;
            }

            IsBusy = true;
            SelectedResults.Clear();

            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();

            var apps = _apps.OrderBy(n => n.Title).ToList();

            if (!string.IsNullOrEmpty(s))
            {
                apps = _apps.Where(n => n.Title.ToLower().Contains(s.ToLower())).ToList();
            }

            await LoadAppListView(apps);

            IsBusy = false;
        }

        private async void ListAllApp()
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                //Call API
                ITechAppStoreNetworkRequestService techAppStoreService = new TechAppStoreService();
                _apps = await techAppStoreService.GetAllAsync();
                await LoadAppListView(_apps);
            }
            catch (Exception ex)
            {

            }
        }

        private async Task LoadAppListView(IList<Models.App> apps)
        {
            foreach (var app in apps)
            {
                var vm = new AppViewModel(app);

                SelectedResults.Add(vm);
            }

            if (apps != null && apps.Count > 0)
            {
                IsSearchAble = true;
            }

            if (!_cancellationTokenSource.IsCancellationRequested)
            {
                try
                {
                    await LoadImage(_cancellationTokenSource.Token);
                }
                catch (Exception ex)
                {
                    string er = ex.Message;
                }
            }
        }

        private async Task LoadImage(CancellationToken cancellationToken)
        {
            foreach (var app in SelectedResults.ToList())
            {
                await app.LoadAppImage();

                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
            }
        }
    }
}
