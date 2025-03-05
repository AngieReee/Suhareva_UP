using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Suhareva_UP.ViewModels;

namespace Suhareva_UP;

public partial class RealizationHistory : UserControl
{

    public RealizationHistory()
    {
        InitializeComponent();
        DataContext = new RealizationHistoryViewModel();
    }

    public RealizationHistory(int id)
    {
        InitializeComponent();
        DataContext = new RealizationHistoryViewModel(id);
    }
}