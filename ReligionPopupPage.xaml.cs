using FundamentalMauiApp.Events;

namespace FundamentalMauiApp;

public partial class ReligionPopupPage : ContentPage
{
    private IChooseEvent _event;

    public ReligionPopupPage(IChooseEvent ev)
    {
        InitializeComponent();
        _event = ev;
    }

    private async void OnChooseReligion(object o, EventArgs s)
    {
        _event.OnChoose("Budha");
        await Navigation.PopModalAsync();
    }

    private async void OnCancelReligion(object o, EventArgs s)
    {
        await Navigation.PopModalAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}