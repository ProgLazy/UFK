using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Omagad;

public partial class admin123 : Window
{
    public admin123()
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