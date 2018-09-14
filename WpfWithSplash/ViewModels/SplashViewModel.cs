using ReactiveUI;

namespace WpfWithSplash.ViewModels
{
    public class SplashViewModel : Base.ViewModelBase
    {
        private string _info;

        public string Info
        {
            get => _info;
            set => this.RaiseAndSetIfChanged(ref _info, value);
        }
    }
}
