using ReactiveUI;

using System.Threading.Tasks;

namespace WpfWithSplash.ViewModels.Base
{
    public abstract class ViewModelBase : ReactiveObject
    {
        bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            protected set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }
        public virtual Task InitializeAsync(object parameter)
        {
            return Task.CompletedTask;
        }
    }
}
