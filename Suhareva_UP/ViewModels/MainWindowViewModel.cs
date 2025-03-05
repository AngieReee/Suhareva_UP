using Avalonia.Controls;
using ReactiveUI;
using Suhareva_UP.Models;

namespace Suhareva_UP.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        UserControl uc = new MenuPage();
        public UserControl Uc { get => uc; set => this.RaiseAndSetIfChanged(ref uc, value); }

        public static _43pSuharevaUpContext connection = new _43pSuharevaUpContext();

        public static MainWindowViewModel Instance;
        

        public MainWindowViewModel()
        {
            Instance = this;
        }
    }
}
