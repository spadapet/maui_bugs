namespace LabelBackground;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSetBackgroundClicked(object sender, EventArgs e)
	{
		this.label.Background = new SolidColorBrush(Colors.Yellow);
	}

    private void OnClearBackgroundClicked(object sender, EventArgs e)
    {
		this.label.Background = null;
    }
}

