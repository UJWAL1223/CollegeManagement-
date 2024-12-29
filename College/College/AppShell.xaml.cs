using College.Pages;

namespace College
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("TechStdPage", typeof(TechStdPage));
            Routing.RegisterRoute("LogInPage", typeof(LogInPage));
            Routing.RegisterRoute("FacultyPage", typeof(FacultyPage));
        }
    }
}
