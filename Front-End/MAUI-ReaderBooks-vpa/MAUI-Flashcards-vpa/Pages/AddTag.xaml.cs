using MAUI_Flashcards_vpa.ViewModels;

namespace MAUI_Flashcards_vpa.Pages;

public partial class AddTag : ContentPage
{
	public AddTag()
	{
		InitializeComponent();
        BindingContext = new BottomNavigationViewModel("Add");
    }
}