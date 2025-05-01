using Avalonia.Controls;

namespace Messaging_Hub.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Extend the client area to include the title bar
        ExtendClientAreaToDecorationsHint = true;

        // Use a custom chrome hint to reduce the title bar size
        ExtendClientAreaChromeHints = Avalonia.Platform.ExtendClientAreaChromeHints.NoChrome;

        // Optional: Adjust the title bar height
        ExtendClientAreaTitleBarHeightHint = 30;
    }
}
