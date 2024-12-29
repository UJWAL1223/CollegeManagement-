namespace College
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMainClicked(object sender, EventArgs e)
        {

            if (sender is Button ClickedBtn)
            {
                string currentBtnId = ClickedBtn.ClassId;
                if (currentBtnId == "MainLogBtn")
                {
                    await Shell.Current.GoToAsync("LogInPage");
                }
                else if (currentBtnId == "MainRegBtn")
                {
                    await Shell.Current.GoToAsync("TechStdPage");
                }
            }
            
        }
    }

}
