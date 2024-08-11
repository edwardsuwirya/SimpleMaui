using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        LabelSignIn.Text = "Please Wait...";
        await Task.Delay(3000);
        var userName = EntryUserName.Text;
        var password = EntryPassword.Text;
        
        if (userName == "enigma" && password == "12345")
        {
            await DisplayAlert("Info", "Welcome", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Invalid User Name or Password", "OK");
        }

        IndicatorSignIn.IsVisible = false;
        LabelSignIn.Text = "Sign In";
        FrameButtonSignIn.IsEnabled = true;


       
    }
}