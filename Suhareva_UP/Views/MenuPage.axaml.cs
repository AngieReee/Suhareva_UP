using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Suhareva_UP.ViewModels;

namespace Suhareva_UP;

public partial class MenuPage : UserControl
{
    public MenuPage()
    {
        InitializeComponent();
        DataContext = new MenuPageViewModel();
    }
}