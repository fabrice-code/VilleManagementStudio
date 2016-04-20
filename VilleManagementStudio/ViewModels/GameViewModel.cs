using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VilleManagementStudio.Models;
using VilleManagementStudio.Service;

namespace VilleManagementStudio.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        static GameViewModel()
        {
            Current =  new GameViewModel();
        }

        public static GameViewModel Current { get; set; }

        private CityModel _cityOne = new CityModel
        {
                CityName = "Brest",
                CityAttractivity = 10,
                CityPoepleCount = 0,
                CityClaimed = true,
                CityCapacity = 0,
                Taxes = 10,
                ElectricCentrals = GenerateService.GenerateTemplateService("Centrale électrique", 8000, 100),
                WaterCentrals = GenerateService.GenerateTemplateService("Traitement des eaux", 11000, 100),
                InternetCentrals = GenerateService.GenerateTemplateService("Répartiteur télécom", 18000, 100),
                PiscineCenter = GenerateService.GenerateTemplate("Piscine", 40000, 4),
                StadeCenter = GenerateService.GenerateTemplate("Stade", 70000, 10),
                NatureParcCenter = GenerateService.GenerateTemplate("Parc", 12000, 1),
                ShootRoomCenter = GenerateService.GenerateTemplate("Salle de shoot", 28000, 2),
                ImagePath = "../Content/Images/Brest.JPG"
        };

        private CityModel _cityTwo = new CityModel
        {
            CityName = "Lorient",
            CityAttractivity = 10,
            CityPoepleCount = 0,
            CityClaimed = true,
            CityCapacity = 0,
            Taxes = 10,
            ElectricCentrals = GenerateService.GenerateTemplateService("Centrale électrique", 8000, 100),
            WaterCentrals = GenerateService.GenerateTemplateService("Traitement des eaux", 11000, 100),
            InternetCentrals = GenerateService.GenerateTemplateService("Répartiteur télécom", 18000, 100),
            PiscineCenter = GenerateService.GenerateTemplate("Piscine", 40000, 4),
            StadeCenter = GenerateService.GenerateTemplate("Stade", 70000, 10),
            NatureParcCenter = GenerateService.GenerateTemplate("Parc", 12000, 1),
            ShootRoomCenter = GenerateService.GenerateTemplate("Salle de shoot", 28000, 2),
            ImagePath = "../Content/Images/Lorient.JPG"
        };

        private CityModel _cityThree = new CityModel
        {
            CityName = "Rennes",
            CityAttractivity = 10,
            CityPoepleCount = 0,
            CityClaimed = true,
            CityCapacity = 0,
            Taxes = 10,
            ElectricCentrals = GenerateService.GenerateTemplateService("Centrale électrique", 8000, 100),
            WaterCentrals = GenerateService.GenerateTemplateService("Traitement des eaux", 11000, 100),
            InternetCentrals = GenerateService.GenerateTemplateService("Répartiteur télécom", 18000, 100),
            PiscineCenter = GenerateService.GenerateTemplate("Piscine", 40000, 4),
            StadeCenter = GenerateService.GenerateTemplate("Stade", 70000, 10),
            NatureParcCenter = GenerateService.GenerateTemplate("Parc", 12000, 1),
            ShootRoomCenter = GenerateService.GenerateTemplate("Salle de shoot", 28000, 2),
            ImagePath = "../Content/Images/Rennes.JPG"
        };

        private CityModel _cityFour = new CityModel
        {
            CityName = "Quimper",
            CityAttractivity = 10,
            CityPoepleCount = 0,
            CityClaimed = true,
            CityCapacity = 0,
            Taxes = 10,
            ElectricCentrals = GenerateService.GenerateTemplateService("Centrale électrique", 8000, 100),
            WaterCentrals = GenerateService.GenerateTemplateService("Traitement des eaux", 11000, 100),
            InternetCentrals = GenerateService.GenerateTemplateService("Répartiteur télécom", 18000, 100),
            PiscineCenter = GenerateService.GenerateTemplate("Piscine", 40000, 4),
            StadeCenter = GenerateService.GenerateTemplate("Stade", 70000, 10),
            NatureParcCenter = GenerateService.GenerateTemplate("Parc", 12000, 1),
            ShootRoomCenter = GenerateService.GenerateTemplate("Salle de shoot", 28000, 2),
            ImagePath = "../Content/Images/Quimper.JPG"
        };

        private CityModel _cityFive = new CityModel
        {
            CityName = "Vannes",
            CityAttractivity = 10,
            CityPoepleCount = 0,
            CityClaimed = true,
            Taxes = 10,
            ElectricCentrals = GenerateService.GenerateTemplateService("Centrale électrique", 8000, 100),
            WaterCentrals = GenerateService.GenerateTemplateService("Traitement des eaux", 11000, 100),
            InternetCentrals = GenerateService.GenerateTemplateService("Répartiteur télécom", 18000, 100),
            PiscineCenter = GenerateService.GenerateTemplate("Piscine", 40000, 4),
            StadeCenter = GenerateService.GenerateTemplate("Stade", 70000, 10),
            NatureParcCenter = GenerateService.GenerateTemplate("Parc", 12000, 1),
            ShootRoomCenter = GenerateService.GenerateTemplate("Salle de shoot", 28000, 2),
            ImagePath = "../Content/Images/Vannes.JPG"
        };

        private CityModel _citySix = new CityModel
        {
            CityName = "Nantes",
            CityAttractivity = 10,
            CityPoepleCount = 0,
            CityClaimed = true,
            Taxes = 10,
            ElectricCentrals = GenerateService.GenerateTemplateService("Centrale électrique", 8000, 100),
            WaterCentrals = GenerateService.GenerateTemplateService("Traitement des eaux", 11000, 100),
            InternetCentrals = GenerateService.GenerateTemplateService("Répartiteur télécom", 18000, 100),
            PiscineCenter = GenerateService.GenerateTemplate("Piscine", 40000, 4),
            StadeCenter = GenerateService.GenerateTemplate("Stade", 70000, 10),
            NatureParcCenter = GenerateService.GenerateTemplate("Parc", 12000, 1),
            ShootRoomCenter = GenerateService.GenerateTemplate("Salle de shoot", 28000, 2),
            ImagePath = "../Content/Images/Nantes.JPG"
        };


        private PlayerModel _player = new PlayerModel
        {
            PlayerName = "Player",
            PlayerMoney = 100000,
            PlayerPoepleCount = 0
        };

        public CityModel CityOne
        {
            get { return _cityOne; }
            set
            {
                if (_cityOne != value)
                {
                    _cityOne = value;
                    OnPropertyChanged("CityOne");
                }
            }
        }

        public CityModel CityTow
        {
            get { return _cityTwo; }
            set
            {
                if (_cityTwo != value)
                {
                    _cityTwo = value;
                    OnPropertyChanged("CityTow");
                }
            }
        }

        public CityModel CityThree
        {
            get { return _cityThree; }
            set
            {
                if (_cityThree != value)
                {
                    _cityThree = value;
                    OnPropertyChanged("CityThree");
                }
            }
        }

        public CityModel CityFour
        {
            get { return _cityFour; }
            set
            {
                if (_cityFour != value)
                {
                    _cityFour = value;
                    OnPropertyChanged("CityFour");
                }
            }
        }

        public CityModel CityFive
        {
            get { return _cityFive; }
            set
            {
                if (_cityFive != value)
                {
                    _cityFive = value;
                    OnPropertyChanged("CityFive");
                }
            }
        }

        public CityModel CitySix
        {
            get { return _citySix; }
            set
            {
                if (_citySix != value)
                {
                    _citySix = value;
                    OnPropertyChanged("CitySix");
                }
            }
        }

        public PlayerModel Player
        {
            get { return _player; }
            set
            {
                if (_player != value)
                {
                    _player = value;
                    OnPropertyChanged("Player");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
