using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPagee : ContentPage
{
    public MainPagee(MainViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
