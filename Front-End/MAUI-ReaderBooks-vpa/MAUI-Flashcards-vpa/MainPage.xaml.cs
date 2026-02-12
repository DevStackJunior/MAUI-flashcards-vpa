using MAUI_Flashcards_vpa.ViewModels;

namespace MAUI_Flashcards_vpa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new BottomNavigationViewModel("Home");
        }
    }

}
