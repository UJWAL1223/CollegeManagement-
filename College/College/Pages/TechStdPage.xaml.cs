namespace College.Pages;

public partial class TechStdPage : ContentPage
{
	public TechStdPage()
	{
		InitializeComponent();
	}

	private async void OnTechStdClicked(object sender, EventArgs e)
	{

		if (sender is Button)
		{

			await Shell.Current.GoToAsync("LogInPage");

		}

	}
}