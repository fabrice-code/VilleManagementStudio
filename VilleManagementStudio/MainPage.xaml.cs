using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using VilleManagementStudio.View;

namespace VilleManagementStudio
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnExitEvent(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void OnNewGameEvent(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PlayerSettingView));
        }

        private void OnCreditEvent(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (CreditView));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame.ContentTransitions = new TransitionCollection
                {
                    new PaneThemeTransition {Edge = EdgeTransitionLocation.Left}
                };
        }
    }
}
