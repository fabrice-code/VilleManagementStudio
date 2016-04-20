using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VilleManagementStudio.Models
{
    class CityModel : INotifyPropertyChanged
    {
        private string _cityName;
        private int _cityPoepleCount;
        private int _cityAttractivity;
        private bool _cityClaimed;
        private int _cityCapacity;
        private int _taxes;
        private ServiceBuildingModel _electricCentrals;
        private ServiceBuildingModel _waterCentrals;
        private ServiceBuildingModel _internetCentrals;
        private AttractivityBuildingModel _piscineCenter;
        private AttractivityBuildingModel _stadeCenter;
        private AttractivityBuildingModel _natureParcCenter;
        private AttractivityBuildingModel _shootRoomCenter;
        private string _imagePath;

        public string CityName
        {
            get { return _cityName; }
            set
            {
                if (_cityName != value)
                {
                    _cityName = value;
                    OnPropertyChanged("CityName");
                }
            }
        }
        public int CityPoepleCount 
        {
            get { return _cityPoepleCount; }
            set
            {
                if (_cityPoepleCount != value)
                {
                    _cityPoepleCount = value;
                    OnPropertyChanged("CityPoepleCount");
                }
            }
        }
        public int CityAttractivity
        {
            get { return _cityAttractivity; }
            set
            {
                if (_cityAttractivity != value)
                {
                    _cityAttractivity = value;
                    OnPropertyChanged("CityAttractivity");
                }
            }
        }
        public bool CityClaimed
        {
            get { return _cityClaimed; }
            set
            {
                if (_cityClaimed != value)
                {
                    _cityClaimed = value;
                    OnPropertyChanged("CityClaimed");
                }
            }
        }
        public int CityCapacity
        {
            get { return _cityCapacity; }
            set
            {
                if (_cityCapacity != value)
                {
                    _cityCapacity = value;
                    OnPropertyChanged("CityCapacity");
                }
            }
        }
        public int Taxes
        {
            get { return _taxes; }
            set
            {
                if (_taxes != value)
                {
                    _taxes = value;
                    OnPropertyChanged("Taxes");
                }
            }
        }
        public ServiceBuildingModel ElectricCentrals
        {
            get { return _electricCentrals; }
            set
            {
                if (_electricCentrals != value)
                {
                    _electricCentrals = value;
                    OnPropertyChanged("ElectricCentrals");
                }
            }
        }
        public ServiceBuildingModel WaterCentrals
        {
            get { return _waterCentrals; }
            set
            {
                if (_waterCentrals != value)
                {
                    _waterCentrals = value;
                    OnPropertyChanged("WaterCentrals");
                }
            }
        }
        public ServiceBuildingModel InternetCentrals
        {
            get { return _internetCentrals; }
            set
            {
                if (_internetCentrals != value)
                {
                    _internetCentrals = value;
                    OnPropertyChanged("InternetCentrals");
                }
            }
        }
        public AttractivityBuildingModel PiscineCenter
        {
            get { return _piscineCenter; }
            set
            {
                if (_piscineCenter != value)
                {
                    _piscineCenter = value;
                    OnPropertyChanged("PiscineCenter");
                }
            }
        }
        public AttractivityBuildingModel StadeCenter
        {
            get { return _stadeCenter; }
            set
            {
                if (_stadeCenter != value)
                {
                    _stadeCenter = value;
                    OnPropertyChanged("StadeCenter");
                }
            }
        }
        public AttractivityBuildingModel NatureParcCenter
        {
            get { return _natureParcCenter; }
            set
            {
                if (_natureParcCenter != value)
                {
                    _natureParcCenter = value;
                    OnPropertyChanged("NatureParcCenter");
                }
            }
        }
        public AttractivityBuildingModel ShootRoomCenter
        {
            get { return _shootRoomCenter; }
            set
            {
                if (_shootRoomCenter != value)
                {
                    _shootRoomCenter = value;
                    OnPropertyChanged("ShootRoomCenter");
                }
            }
        }
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                if (_imagePath != value)
                {
                    _imagePath = value;
                    OnPropertyChanged("ImagePath");
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
