using FundamentalMauiApp.Resources.String;

namespace FundamentalMauiApp;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        IndicatorSignIn.IsVisible = false;
    }

    private async void OnSignUp(Object e, EventArgs s)
    {
        // GoToAsync will not create multiple instance of the same page
        // PushAsync will create multiple instance

        // await Shell.Current.GoToAsync(nameof(SignUpPage));
        // await Shell.Current.GoToAsync($"{nameof(SignUpPage)}?param=new");
        var navigationParam = new Dictionary<string, object>
        {
            { "param1", "new" },
            { "param2", "mobile" }
        };
        await Shell.Current.GoToAsync($"//{nameof(SignupPage)}", navigationParam);
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

        await Task.Delay(1500);
        var userName = EntryUserName.Text;
        var password = EntryPassword.Text;

        if (userName == "edo" && password == "123")
        {
            await Shell.Current.GoToAsync("//PinPage");
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