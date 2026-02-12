using MAUI_Flashcards_vpa.ViewModels;

namespace MAUI_Flashcards_vpa.Pages;

public partial class Tags : ContentPage
{
    public Tags()
    {
        InitializeComponent();
        BindingContext = new BottomNavigationViewModel("Tags");
    }
}