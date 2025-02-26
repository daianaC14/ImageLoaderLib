using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPageee : ContentPage
{
    public MainPageee(MainViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
