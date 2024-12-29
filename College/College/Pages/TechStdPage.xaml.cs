namespace College.Pages;

public partial class TechStdPage : ContentPage
{
	public TechStdPage()
	{
		InitializeComponent();
	}

	private async void OnTechStdClicked(object sender, EventArgs e)
	{

		if (sender is Button clickedBtn)
		{
			string currentBtn = clickedBtn.ClassId;

			if(currentBtn == "TechBtn")
			{
				await Shell.Current.GoToAsync("LogInPage");
			}
			else if(currentBtn == "StdBtn")
			{
				await Shell.Current.GoToAsync("FacultyPage");
			}

		}

	}
}