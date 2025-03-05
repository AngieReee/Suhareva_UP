using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Suhareva_UP.ViewModels;

namespace Suhareva_UP;

public partial class ChangePartner : UserControl
{
    public ChangePartner()
    {
        InitializeComponent();
        DataContext = new ChangePartnerViewModel();
    }

    public ChangePartner(int id)
    {
        InitializeComponent();
        DataContext = new ChangePartnerViewModel(id);
    }
}