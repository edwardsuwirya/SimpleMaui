using FundamentalMauiApp.Events;

namespace FundamentalMauiApp;

[QueryProperty(nameof(Param1), "param1")]
[QueryProperty(nameof(Param2), "param2")]
public partial class SignupPage : ContentPage, IChooseEvent
{
    private string _prm1;
    private string _prm2;

    public string Param1
    {
        set => _prm1 = value;
    }

    public string Param2
    {
        set => _prm2 = value;
    }

    public SignupPage()
    {
        InitializeComponent();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    private async void OnPopReligion(object o, EventArgs s)
    {
        Console.WriteLine("param1=>" + _prm1);
        Console.WriteLine("param2=>" + _prm2);
        await Navigation.PushModalAsync(new ReligionPopupPage(this));
    }

    private async void OnSignIn(object o, EventArgs s)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    public void OnChoose(string data)
    {
        Console.WriteLine("Religion=>" + data);
    }
}