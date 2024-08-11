namespace FundamentalMauiApp;

public partial class PINPage : ContentPage
{
    private readonly List<string> _pin = [];
    private readonly List<Frame> _frames = [];

    public PINPage()
    {
        InitializeComponent();
        _frames.Add(Icon1);
        _frames.Add(Icon2);
        _frames.Add(Icon3);
        _frames.Add(Icon4);
        _frames.Add(Icon5);
        _frames.Add(Icon6);
    }

    private void RenderImage()
    {
        for (var i = 0; i < _pin.Count; i++)
        {
            _frames[i].BackgroundColor = Colors.Black;
        }

        for (var j = _pin.Count; j < 6; j++)
        {
            _frames[j].BackgroundColor = Colors.LightGray;
        }
    }

    private void AddPin(string sNumber)
    {
        _pin.Add(sNumber);
        RenderImage();
    }

    private void DeletePin()
    {
        if (_pin.Count > 0)
        {
            _pin.RemoveAt(_pin.Count - 1);
            RenderImage();
        }
    }

    private void OnButtonNum1Click(Object s, EventArgs e)
    {
        AddPin("1");
    }

    private void OnButtonNum2Click(Object s, EventArgs e)
    {
        AddPin("2");
    }

    private void OnButtonNum3Click(Object s, EventArgs e)
    {
        AddPin("3");
    }

    private void OnButtonNum4Click(Object s, EventArgs e)
    {
        AddPin("4");
    }

    private void OnButtonNum5Click(Object s, EventArgs e)
    {
        AddPin("5");
    }

    private void OnButtonNum6Click(Object s, EventArgs e)
    {
        AddPin("6");
    }

    private void OnButtonNum7Click(Object s, EventArgs e)
    {
        AddPin("7");
    }

    private void OnButtonNum8Click(Object s, EventArgs e)
    {
        AddPin("8");
    }

    private void OnButtonNum9Click(Object s, EventArgs e)
    {
        AddPin("9");
    }

    private void OnButtonNum0Click(Object s, EventArgs e)
    {
        AddPin("0");
    }

    private void OnButtonDeleteClick(Object s, EventArgs e)
    {
        DeletePin();
    }
}