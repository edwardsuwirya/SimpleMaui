using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentalMauiApp.Events;

namespace FundamentalMauiApp;

[QueryProperty(nameof(Param1), "param1")]
[QueryProperty(nameof(Param2), "param2")]
public partial class SignUpPage : ContentPage,IChooseEvent
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

    public SignUpPage()
    {
        InitializeComponent();
    }

    private async void OnPopReligion(object o, EventArgs s)
    {
        Console.WriteLine("param1=>" + _prm1);
        Console.WriteLine("param2=>" + _prm2);
        await Navigation.PushModalAsync(new ReligionPopupPage(this));
    }

    private async void OnGoBack(object o, EventArgs s)
    {
        await Shell.Current.GoToAsync("..");
    }

    public void OnChoose(string data)
    {
        Console.WriteLine("Religion=>" + data);
    }
}