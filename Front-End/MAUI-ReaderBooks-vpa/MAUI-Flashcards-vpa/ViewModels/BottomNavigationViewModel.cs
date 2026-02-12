using Microsoft.Maui.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI_Flashcards_vpa.ViewModels
{
    /// <summary>
    /// 1. Déclenchement événement : clique sur "Settings".
    /// 2. DESTRUCTION (instance actuelle): 
    /// 2.1 Home     | MainPage.xaml
    /// 2.1 ViewModel| BottomNavigationViewModel.cs 
    /// détruits
    /// 2.2 Libération de la mémoire
    /// 3. CREATION (nouvelle instance): 
    /// 3.1 Pages     | Settings.xaml
    /// 3.1 ViewModels| BottomNavigationViewModel en lui passant la chaîne "Settings".
    /// 3.2 
    /// 4. CALCULE : 
    /// Le constructeur exécute la comparaison : 
    /// 4.1 Est-ce que 'Settings' == 'Home' ? Non -> Gris. 
    /// 4.2 Est-ce que 'Tags' == 'Settings' ? Non -> Gris.
    /// ...
    /// 4.3 Est-ce que 'Settings' == 'Settings' ? Oui -> Violet.
    /// 5. AFFICHAGE : 
    /// 5.1 Views    | BottomNavigation.xaml (Le XAML lit ces valeurs une seule fois et dessine la barre avec les nouvelles couleurs).
    /// </summary>
    public class BottomNavigationViewModel
    {
        public Color HomeColor { get; }
        public Color TagsColor { get; }
        public Color AddColor { get; }
        public Color SettingsColor { get; }

        public ICommand GoHomeCommand { get; }
        public ICommand GoTagsCommand { get; }
        public ICommand GoAddTagCommand { get; }
        public ICommand GoSettingsCommand { get; }

        /// <summary>
        /// Etablit 2 couleurs de référence, vérifie l'état statique de sélection d'un onglet : 
        ///     - 1 couleur par défaut pour les onglets non sélectionnés
        ///     - 1 couleur pour un onglet activé
        /// </summary>
        /// <param name="activeTab">propriété statique de sélection de l'onglet de navigation sélectionné</param>
        public BottomNavigationViewModel(string activeTab)
        {
            // propriété de couleur activant le texte comme étant sélectionné
            var active = Color.FromHex("#6F3FF5");
            // propriété de couleur lorsque onglet non-activé
            var inactive = Color.FromHex("#9CA3AF");

            // Si activeTab = Home -> sélectionne couleur #6F3FF5 étant 'activé'
            HomeColor = activeTab == "Home" ? active : inactive;
            TagsColor = activeTab == "Tags" ? active : inactive;
            AddColor = activeTab == "Add" ? active : inactive;
            SettingsColor = activeTab == "Settings" ? active : inactive;

            GoHomeCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//home"));

            GoTagsCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//tags"));

            GoAddTagCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//add-tag"));

            GoSettingsCommand = new Command(async () =>
                await Shell.Current.GoToAsync("//settings"));
        }
    }
}
