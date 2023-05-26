using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaRadioNav;

public partial class MainViewModel:ObservableObject
{
    [ObservableProperty]
    private string _page;
    [RelayCommand]
    private void Navigate(string path)
    {
        Page = path;
    }
}