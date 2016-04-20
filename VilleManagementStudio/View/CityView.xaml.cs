using Windows.UI.Xaml.Controls;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using VilleManagementStudio.Models;
using VilleManagementStudio.Service;
using VilleManagementStudio.ViewModels;

namespace VilleManagementStudio.View
{
    public sealed partial class CityView : Page
    {
        public CityView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame.ContentTransitions = new TransitionCollection
                {
                    new PaneThemeTransition {Edge = EdgeTransitionLocation.Left}
                };
            var currentCity = e.Parameter as CityModel;
            if (currentCity != null)
            {
                switch (currentCity.CityName)
                {
                    case "Brest":
                        this.DataContext = GameViewModel.Current.CityOne;
                        break;
                    case "Lorient":
                        this.DataContext = GameViewModel.Current.CityTow;
                        break;
                    case "Rennes":
                        this.DataContext = GameViewModel.Current.CityThree;
                        break;
                    case "Quimper":
                        this.DataContext = GameViewModel.Current.CityFour;
                        break;
                    case "Vannes":
                        this.DataContext = GameViewModel.Current.CityFive;
                        break;
                    case "Nantes":
                        this.DataContext = GameViewModel.Current.CitySix;
                        break;
                }
            }
        }

        private void BuyTelecomEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentTelecomPrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrentTelecomQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }
        private void BuyWaterEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentWaterPrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrentWaterQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }

        private void BuyElecEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentElecPrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrentElecQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }

        private void BuyPiscineEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentPiscinePrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrentPiscineQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }

        private void BuyStadeEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentStadePrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrentStadeQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }

        private void BuyParcEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentParcPrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrentParcQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }

        private void BuyShootRoomEvent(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (GameViewModel.Current.Player.PlayerMoney > GameViewModelService.GetCurrentShootRoomPrice(CurrentCityName.Text))
            {
                GameViewModelService.SetCurrenShootRoomQuantity(CurrentCityName.Text);
                BlopSound.Play();
            }
        }

        private void UpCityTaxes(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            GameViewModelService.SetUpCityTaxes(CurrentCityName.Text);
            BlopSound.Play();
        }

        private void DownCityTaxes(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            GameViewModelService.SetDownCityTaxes(CurrentCityName.Text);
            BlopSound.Play();
        }
    }
}
