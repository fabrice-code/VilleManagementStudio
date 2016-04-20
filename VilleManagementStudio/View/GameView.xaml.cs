using System;
using System.Threading.Tasks;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using VilleManagementStudio.Service;
using VilleManagementStudio.ViewModels;

namespace VilleManagementStudio.View
{
    public sealed partial class GameView : Page
    {
        private bool _isPlaying;

        public GameView()
        {
            _isPlaying = true;
            this.InitializeComponent();
            this.DataContext = GameViewModel.Current;
            ThreadPool.RunAsync(GameLifeLoop);
        }

        private async void GameLifeLoop(object state)
        {
            while (_isPlaying)
            {
                for (int i = 1; i < 11; i++)
                {
                    if (i == 10)
                    {
                        Dispatcher.RunAsync(CoreDispatcherPriority.Normal, GameViewModelService.SetPlayerMoney);
                        Dispatcher.RunAsync(CoreDispatcherPriority.Normal, GameViewModelService.SetPoepleInCity);
                    }
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    Dispatcher.RunAsync(CoreDispatcherPriority.Normal, UpdateBar);
                }
            }
        }

        private void UpdateBar()
        {
            if (UpdateGameBar.Value != 9)
            {
                UpdateGameBar.Value +=1;
            }
            else
            {
                ThickSound.Play();
                UpdateGameBar.Value = 0;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame.ContentTransitions = new TransitionCollection
                {
                    new PaneThemeTransition {Edge = EdgeTransitionLocation.Right}
                };
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            CityGrid.Visibility = Visibility.Collapsed;
        }

        private void CityOneClickEvent(object sender, RoutedEventArgs e)
        {
            CityFrame.Navigate(typeof(CityView), GameViewModel.Current.CityOne);
            CityGrid.Visibility = Visibility.Visible;
            BlopSound.Play();
        }

        private void CityTwoClickEvent(object sender, RoutedEventArgs e)
        {
            CityFrame.Navigate(typeof(CityView), GameViewModel.Current.CityTow);
            CityGrid.Visibility = Visibility.Visible;
            BlopSound.Play();
        }

        private void CityThreeClickEvent(object sender, RoutedEventArgs e)
        {
            CityFrame.Navigate(typeof(CityView), GameViewModel.Current.CityThree);
            CityGrid.Visibility = Visibility.Visible;
            BlopSound.Play();
        }

        private void CityFourClickEvent(object sender, RoutedEventArgs e)
        {
            CityFrame.Navigate(typeof(CityView), GameViewModel.Current.CityFour);
            CityGrid.Visibility = Visibility.Visible;
            BlopSound.Play();
        }

        private void CityFiveClickEvent(object sender, RoutedEventArgs e)
        {
            CityFrame.Navigate(typeof(CityView), GameViewModel.Current.CityFive);
            CityGrid.Visibility = Visibility.Visible;
            BlopSound.Play();
        }

        private void CitySixClickEvent(object sender, RoutedEventArgs e)
        {
            CityFrame.Navigate(typeof(CityView), GameViewModel.Current.CitySix);
            CityGrid.Visibility = Visibility.Visible;
            BlopSound.Play();
        }

        private void ReturnMenuEvent(object sender, RoutedEventArgs e)
        {
            _isPlaying = false;
            Frame.Navigate(typeof(MainPage));
        }
    }
}
