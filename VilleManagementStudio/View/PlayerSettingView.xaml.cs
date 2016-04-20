using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=234238
using VilleManagementStudio.Service;
using VilleManagementStudio.ViewModels;

namespace VilleManagementStudio.View
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class PlayerSettingView : Page
    {
        public PlayerSettingView()
        {
            this.InitializeComponent();
            this.DataContext = GameViewModel.Current;
        }

        private void OnNewGameEvent(object sender, RoutedEventArgs e)
        {
            GameViewModelService.ResetGameModel();
            Frame.Navigate(typeof (GameView));
        }
    }
}
