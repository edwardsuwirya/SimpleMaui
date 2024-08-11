using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentalMauiApp.Resources.String;

namespace FundamentalMauiApp;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        IndicatorSignIn.IsVisible = false;
    }

    private async void OnSignIn(Object e, EventArgs s)
    {
        FrameButtonSignIn.IsEnabled = false;
        IndicatorSignIn.IsVisible = true;
        LabelSignIn.Text = Greetings.PleaseWait;
        Resources["buttonPrimaryColor"] = "#9880e5";
        Resources["textButtonSecondaryColor"] = Colors.Gray;
        
        await Task.Delay(3000);
        var userName = EntryUserName.Text;
        var password = EntryPassword.Text;

        if (userName == "enigma" && password == "12345")
        {
            await DisplayAlert(Greetings.Info, Greetings.Welcome, Greetings.Ok);
        }
        else
        {
            await DisplayAlert(Greetings.Error, Greetings.InvalidAccess, Greetings.Ok);
        }

        IndicatorSignIn.IsVisible = false;
        LabelSignIn.Text = Greetings.SignIn;
        FrameButtonSignIn.IsEnabled = true;
        Resources["buttonPrimaryColor"] = "#512BD4";
        Resources["textButtonSecondaryColor"] = "#DFD8F7";
    }
}