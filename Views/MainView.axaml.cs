using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Messaging_Hub.Views;

public partial class MainView : UserControl
{
    private enum CurrentService
    {
        Discord,
        Messenger,
        WhatsApp,
        Telegram
    }
    private CurrentService _currentService = CurrentService.Discord;

    public MainView()
    {
        InitializeComponent();

    }

    // CloseWindow
    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var window = this.GetParentWindow();
        if (window != null)
        {
            window.Close();
        }
    }    
    private void Discord_Btn(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (_currentService != CurrentService.Discord)
        {
            DiscordWebw.IsVisible = true;
            DiscordWebw.IsEnabled = true;
            MessengerWebw.IsVisible = false;
            MessengerWebw.IsEnabled = false;
            WhatsAppWebw.IsVisible = false;
            WhatsAppWebw.IsEnabled = false;
            TelegramWebw.IsVisible = false;
            TelegramWebw.IsEnabled = false;
            _currentService = CurrentService.Discord;
        }
    }
    private void Messenger_Btn(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (_currentService != CurrentService.Messenger)
        {
            DiscordWebw.IsVisible = false;
            DiscordWebw.IsEnabled = false;
            MessengerWebw.IsVisible = true;
            MessengerWebw.IsEnabled = true;
            WhatsAppWebw.IsVisible = false;
            WhatsAppWebw.IsEnabled = false;
            TelegramWebw.IsVisible = false;
            TelegramWebw.IsEnabled = false;
            _currentService = CurrentService.Messenger;
        }
    }

    private void WhatsApp_Btn(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (_currentService != CurrentService.WhatsApp)
        {
            DiscordWebw.IsVisible = false;
            DiscordWebw.IsEnabled = false;
            MessengerWebw.IsVisible = false;
            MessengerWebw.IsEnabled = false;
            WhatsAppWebw.IsVisible = true;
            WhatsAppWebw.IsEnabled = true;
            TelegramWebw.IsVisible = false;
            TelegramWebw.IsEnabled = false;
            _currentService = CurrentService.WhatsApp;
        }
}

    private void Telegram_Btn(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (_currentService != CurrentService.Telegram)
        {
            DiscordWebw.IsVisible = false;
            DiscordWebw.IsEnabled = false;
            MessengerWebw.IsVisible = false;
            MessengerWebw.IsEnabled = false;
            WhatsAppWebw.IsVisible = false;
            WhatsAppWebw.IsEnabled = false;
            TelegramWebw.IsVisible = true;
            TelegramWebw.IsEnabled = true;
            _currentService = CurrentService.Telegram;
        }
    }

    // Maximize the window
    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

        var window = this.GetParentWindow();
        if (window != null)
        {
            window.WindowState = window.WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;

            //Todo Make it so the icon's data pulled from the app.axaml
            if (window.WindowState == WindowState.Maximized)
            {
                MaximizePathIcon.Data = StreamGeometry.Parse("M1 11h6v6M17 7h-6V1M11 7l7-7M0 18l7-7");
            }
            else
            {
                MaximizePathIcon.Data = StreamGeometry.Parse("M13 1h6v6M7 19H1v-6M19 1l-7 7M1 19l7-7");
            }
        }
    }
    // Minimize the window
    private void Button_Click_2(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var window = this.GetParentWindow();
        if (window != null)
        {
            window.WindowState = WindowState.Minimized;
        }
       
    }

    // Helper method to get the parent window
    private Window? GetParentWindow()
    {
        return this.VisualRoot as Window;
    }

  
}
