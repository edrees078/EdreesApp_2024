using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace EdreesApp_2024;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    public static async Task DisplayToastAsync(string message)
    {
        var toast = Toast.Make(message, ToastDuration.Short);
        await toast.Show();
    }
}
