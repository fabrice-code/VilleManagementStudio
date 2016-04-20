using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VilleManagementStudio.Models
{
    class PlayerModel : INotifyPropertyChanged
    {
        private string _playerName ;
        private int _playerMoney;
        private int _playerPoepleCount;

        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                if (_playerName != value)
                {
                    _playerName = value;
                    OnPropertyChanged("PlayerName");
                }
            }
        }
        public int PlayerMoney
        {
            get { return _playerMoney; }
            set
            {
                if (_playerMoney != value)
                {
                    _playerMoney = value;
                    OnPropertyChanged("PlayerMoney");
                }
            }
        }
        public int PlayerPoepleCount
        {
            get { return _playerPoepleCount; }
            set
            {
                if (_playerPoepleCount != value)
                {
                    _playerPoepleCount = value;
                    OnPropertyChanged("PlayerPoepleCount");
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
