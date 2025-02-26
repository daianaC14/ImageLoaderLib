namespace ImageLoaderLib;

public partial class BindableImage : ContentView
{
    public static readonly BindableProperty ImagePathProperty =
        BindableProperty.Create(nameof(ImagePath), typeof(string), typeof(BindableImage), default(string), propertyChanged: OnImagePathChanged);

    public string ImagePath
    {
        get => (string)GetValue(ImagePathProperty);
        set => SetValue(ImagePathProperty, value);
    }

    public BindableImage()
    {
        InitializeComponent();
    }

    private static void OnImagePathChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is BindableImage control && newValue is string newPath)
        {
            control.LoadImage(newPath);
        }
    }

    private void LoadImage(string path)
    {
        if (File.Exists(path))
        {
            imageControl.Source = ImageSource.FromFile(path);
        }
        else
        {
            imageControl.Source = "noimg.png";
        }
    }
}


