namespace MAUI_Flashcards_vpa
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("home", typeof(MainPage));
            Routing.RegisterRoute("tags", typeof(Pages.Tags));
            Routing.RegisterRoute("add-tag", typeof(Pages.AddTag));
            //Routing.RegisterRoute("settings", typeof(Pages.Settings));
        }
    }
}
