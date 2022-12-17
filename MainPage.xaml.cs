namespace Muresan_Andreea_Bianca_Lab7;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"{count} hug";
		else
			CounterBtn.Text = $"{count} hugs";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

