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
        var buttonFrameNormalStyle = Application.Current?.Resources["ButtonFrameNormal"] as Style;
        var buttonFrameDisabledStyle = Application.Current?.Resources["ButtonFrameDisabled"] as Style;
        var buttonFrameLabelNormalStyle = Application.Current?.Resources["ButtonLabelNormal"] as Style;
        var buttonFrameLabelDisabledStyle = Application.Current?.Resources["ButtonLabelDisabled"] as Style;

        FrameButtonSignIn.IsEnabled = false;
        IndicatorSignIn.IsVisible = true;
        LabelSignIn.Text = Greetings.PleaseWait;


        FrameButtonSignIn.Style = buttonFrameDisabledStyle;
        LabelSignIn.Style = buttonFrameLabelDisabledStyle;

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
        FrameButtonSignIn.Style = buttonFrameNormalStyle;
        LabelSignIn.Style = buttonFrameLabelNormalStyle;
    }
}