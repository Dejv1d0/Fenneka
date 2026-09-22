using Android.App;
using Android.Content.PM;
using Android.OS;
using AndroidX.Core.View;

namespace Fenneka.Mobile
{
    [Activity(
        Theme = "@style/Maui.SplashTheme",
        MainLauncher = true,
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges =
            ConfigChanges.ScreenSize |
            ConfigChanges.Orientation |
            ConfigChanges.UiMode |
            ConfigChanges.ScreenLayout |
            ConfigChanges.SmallestScreenSize |
            ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            // pozwala aplikacji rysować pod systemowymi paskami
            WindowCompat.SetDecorFitsSystemWindows(Window!, false);

            base.OnCreate(savedInstanceState);

            // usuwa dodatkową przyciemnioną warstwę przy nawigacji 3-przyciskowej
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
            {
                Window!.NavigationBarContrastEnforced = false;
            }
        }
    }
}