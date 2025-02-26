using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
