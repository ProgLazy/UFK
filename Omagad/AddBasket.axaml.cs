using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Omagad;

public partial class AddBasket : Window
{
    public AddBasket()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}