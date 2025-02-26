using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPageeee : ContentPage
{
    public MainPageeee(MainViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}
