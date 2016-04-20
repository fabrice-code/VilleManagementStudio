using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VilleManagementStudio.Models;
using VilleManagementStudio.ViewModels;

namespace VilleManagementStudio.Service
{
    class GameViewModelService
    {
        public static int GetCurrentElecPrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.ElectricCentrals.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.ElectricCentrals.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.ElectricCentrals.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.ElectricCentrals.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.ElectricCentrals.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.ElectricCentrals.Price;

            }
            return 0;
        }

        public static int GetCurrentWaterPrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.WaterCentrals.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.WaterCentrals.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.WaterCentrals.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.WaterCentrals.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.WaterCentrals.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.WaterCentrals.Price;

            }
            return 0;
        }

        public static int GetCurrentTelecomPrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.InternetCentrals.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.InternetCentrals.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.InternetCentrals.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.InternetCentrals.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.InternetCentrals.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.InternetCentrals.Price;

            }
            return 0;
        }

        public static void SetCurrentElecQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.ElectricCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.ElectricCentrals.Price;
                    GameViewModel.Current.CityOne.ElectricCentrals.Price += 2000;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.ElectricCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.ElectricCentrals.Price;
                    GameViewModel.Current.CityTow.ElectricCentrals.Price += 2000;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.ElectricCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.ElectricCentrals.Price;
                    GameViewModel.Current.CityThree.ElectricCentrals.Price += 2000;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.ElectricCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.ElectricCentrals.Price;
                    GameViewModel.Current.CityFour.ElectricCentrals.Price += 2000;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.ElectricCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.ElectricCentrals.Price;
                    GameViewModel.Current.CityFive.ElectricCentrals.Price += 2000;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.ElectricCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.ElectricCentrals.Price;
                    GameViewModel.Current.CitySix.ElectricCentrals.Price += 2000;
                    break;

            }
            SetCurrentCityCapacity(cityName);
        }

        public static void SetCurrentWaterQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.WaterCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.WaterCentrals.Price;
                    GameViewModel.Current.CityOne.WaterCentrals.Price += 1500;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.WaterCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.WaterCentrals.Price;
                    GameViewModel.Current.CityTow.WaterCentrals.Price += 1500;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.WaterCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.WaterCentrals.Price;
                    GameViewModel.Current.CityThree.WaterCentrals.Price += 1500;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.WaterCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.WaterCentrals.Price;
                    GameViewModel.Current.CityFour.WaterCentrals.Price += 1500;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.WaterCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.WaterCentrals.Price;
                    GameViewModel.Current.CityFive.WaterCentrals.Price += 1500;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.WaterCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.WaterCentrals.Price;
                    GameViewModel.Current.CitySix.WaterCentrals.Price += 1500;
                    break;

            }
            SetCurrentCityCapacity(cityName);
        }

        public static void SetCurrentTelecomQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.InternetCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.InternetCentrals.Price;
                    GameViewModel.Current.CityOne.InternetCentrals.Price += 2500;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.InternetCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.InternetCentrals.Price;
                    GameViewModel.Current.CityTow.InternetCentrals.Price += 2500;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.InternetCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.InternetCentrals.Price;
                    GameViewModel.Current.CityThree.InternetCentrals.Price += 2500;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.InternetCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.InternetCentrals.Price;
                    GameViewModel.Current.CityFour.InternetCentrals.Price += 2500;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.InternetCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.InternetCentrals.Price;
                    GameViewModel.Current.CityFive.InternetCentrals.Price += 2500;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.InternetCentrals.Quantity++;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.InternetCentrals.Price;
                    GameViewModel.Current.CitySix.InternetCentrals.Price += 2500;
                    break;

            }
            SetCurrentCityCapacity(cityName);
        }

        public static void SetCurrentCityCapacity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    if (GameViewModel.Current.CityOne.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityOne.ElectricCentrals.Quantity &&
                        GameViewModel.Current.CityOne.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityOne.WaterCentrals.Quantity)
                    {
                        GameViewModel.Current.CityOne.CityCapacity += 100;
                    }
                    break;
                case "Lorient":
                    if (GameViewModel.Current.CityTow.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityTow.ElectricCentrals.Quantity &&
                        GameViewModel.Current.CityTow.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityTow.WaterCentrals.Quantity)
                    {
                        GameViewModel.Current.CityTow.CityCapacity += 100;
                    }
                    break;
                case "Rennes":
                    if (GameViewModel.Current.CityThree.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityThree.ElectricCentrals.Quantity &&
                        GameViewModel.Current.CityThree.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityThree.WaterCentrals.Quantity)
                    {
                        GameViewModel.Current.CityThree.CityCapacity += 100;
                    }
                    break;
                case "Quimper":
                    if (GameViewModel.Current.CityFour.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityFour.ElectricCentrals.Quantity &&
                        GameViewModel.Current.CityFour.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityFour.WaterCentrals.Quantity)
                    {
                        GameViewModel.Current.CityFour.CityCapacity += 100;
                    }
                    break;
                case "Vannes":
                    if (GameViewModel.Current.CityFive.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityFive.ElectricCentrals.Quantity &&
                        GameViewModel.Current.CityFive.InternetCentrals.Quantity ==
                        GameViewModel.Current.CityFive.WaterCentrals.Quantity)
                    {
                        GameViewModel.Current.CityFive.CityCapacity += 100;
                    }
                    break;
                case "Nantes":
                    if (GameViewModel.Current.CitySix.InternetCentrals.Quantity ==
                        GameViewModel.Current.CitySix.ElectricCentrals.Quantity &&
                        GameViewModel.Current.CitySix.InternetCentrals.Quantity ==
                        GameViewModel.Current.CitySix.WaterCentrals.Quantity)
                    {
                        GameViewModel.Current.CitySix.CityCapacity += 100;
                    }
                    break;
            }
        }

        public static int GetCurrentPiscinePrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.PiscineCenter.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.PiscineCenter.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.PiscineCenter.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.PiscineCenter.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.PiscineCenter.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.PiscineCenter.Price;

            }
            return 0;
        }

        public static int GetCurrentStadePrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.StadeCenter.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.StadeCenter.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.StadeCenter.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.StadeCenter.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.StadeCenter.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.StadeCenter.Price;

            }
            return 0;
        }

        public static int GetCurrentParcPrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.NatureParcCenter.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.NatureParcCenter.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.NatureParcCenter.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.NatureParcCenter.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.NatureParcCenter.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.NatureParcCenter.Price;

            }
            return 0;
        }

        public static int GetCurrentShootRoomPrice(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    return GameViewModel.Current.CityOne.ShootRoomCenter.Price;
                case "Lorient":
                    return GameViewModel.Current.CityTow.ShootRoomCenter.Price;
                case "Rennes":
                    return GameViewModel.Current.CityThree.ShootRoomCenter.Price;
                case "Quimper":
                    return GameViewModel.Current.CityFour.ShootRoomCenter.Price;
                case "Vannes":
                    return GameViewModel.Current.CityFive.ShootRoomCenter.Price;
                case "Nantes":
                    return GameViewModel.Current.CitySix.ShootRoomCenter.Price;

            }
            return 0;
        }

        public static void SetCurrentPiscineQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.PiscineCenter.Quantity++;
                    GameViewModel.Current.CityOne.CityAttractivity += GameViewModel.Current.CityOne.PiscineCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.PiscineCenter.Price;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.PiscineCenter.Quantity++;
                    GameViewModel.Current.CityTow.CityAttractivity += GameViewModel.Current.CityTow.PiscineCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.PiscineCenter.Price;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.PiscineCenter.Quantity++;
                    GameViewModel.Current.CityThree.CityAttractivity += GameViewModel.Current.CityThree.PiscineCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.PiscineCenter.Price;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.PiscineCenter.Quantity++;
                    GameViewModel.Current.CityOne.CityAttractivity += GameViewModel.Current.CityFour.PiscineCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.PiscineCenter.Price;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.PiscineCenter.Quantity++;
                    GameViewModel.Current.CityFive.CityAttractivity += GameViewModel.Current.CityFive.PiscineCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.PiscineCenter.Price;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.PiscineCenter.Quantity++;
                    GameViewModel.Current.CitySix.CityAttractivity += GameViewModel.Current.CitySix.PiscineCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.PiscineCenter.Price;
                    break;

            }
        }

        public static void SetCurrentStadeQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.StadeCenter.Quantity++;
                    GameViewModel.Current.CityOne.CityAttractivity += GameViewModel.Current.CityOne.StadeCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.StadeCenter.Price;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.StadeCenter.Quantity++;
                    GameViewModel.Current.CityTow.CityAttractivity += GameViewModel.Current.CityTow.StadeCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.StadeCenter.Price;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.StadeCenter.Quantity++;
                    GameViewModel.Current.CityThree.CityAttractivity += GameViewModel.Current.CityThree.StadeCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.StadeCenter.Price;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.StadeCenter.Quantity++;
                    GameViewModel.Current.CityFour.CityAttractivity += GameViewModel.Current.CityFour.StadeCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.StadeCenter.Price;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.StadeCenter.Quantity++;
                    GameViewModel.Current.CityFive.CityAttractivity += GameViewModel.Current.CityFive.StadeCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.StadeCenter.Price;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.StadeCenter.Quantity++;
                    GameViewModel.Current.CitySix.CityAttractivity += GameViewModel.Current.CitySix.StadeCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.StadeCenter.Price;
                    break;

            }
        }

        public static void SetCurrentParcQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.NatureParcCenter.Quantity++;
                    GameViewModel.Current.CityOne.CityAttractivity += GameViewModel.Current.CityOne.NatureParcCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.NatureParcCenter.Price;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.NatureParcCenter.Quantity++;
                    GameViewModel.Current.CityTow.CityAttractivity += GameViewModel.Current.CityTow.NatureParcCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.NatureParcCenter.Price;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.NatureParcCenter.Quantity++;
                    GameViewModel.Current.CityThree.CityAttractivity += GameViewModel.Current.CityThree.NatureParcCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.NatureParcCenter.Price;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.NatureParcCenter.Quantity++;
                    GameViewModel.Current.CityFour.CityAttractivity += GameViewModel.Current.CityFour.NatureParcCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.NatureParcCenter.Price;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.NatureParcCenter.Quantity++;
                    GameViewModel.Current.CityFive.CityAttractivity += GameViewModel.Current.CityFive.NatureParcCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.NatureParcCenter.Price;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.NatureParcCenter.Quantity++;
                    GameViewModel.Current.CitySix.CityAttractivity += GameViewModel.Current.CitySix.NatureParcCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.NatureParcCenter.Price;
                    break;

            }
        }

        public static void SetCurrenShootRoomQuantity(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    GameViewModel.Current.CityOne.ShootRoomCenter.Quantity++;
                    GameViewModel.Current.CityOne.CityAttractivity += GameViewModel.Current.CityOne.ShootRoomCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityOne.ShootRoomCenter.Price;
                    break;
                case "Lorient":
                    GameViewModel.Current.CityTow.ShootRoomCenter.Quantity++;
                    GameViewModel.Current.CityTow.CityAttractivity += GameViewModel.Current.CityTow.ShootRoomCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityTow.ShootRoomCenter.Price;
                    break;
                case "Rennes":
                    GameViewModel.Current.CityThree.ShootRoomCenter.Quantity++;
                    GameViewModel.Current.CityThree.CityAttractivity += GameViewModel.Current.CityThree.ShootRoomCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityThree.ShootRoomCenter.Price;
                    break;
                case "Quimper":
                    GameViewModel.Current.CityFour.ShootRoomCenter.Quantity++;
                    GameViewModel.Current.CityFour.CityAttractivity += GameViewModel.Current.CityFour.ShootRoomCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFour.ShootRoomCenter.Price;
                    break;
                case "Vannes":
                    GameViewModel.Current.CityFive.ShootRoomCenter.Quantity++;
                    GameViewModel.Current.CityFive.CityAttractivity += GameViewModel.Current.CityFive.ShootRoomCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CityFive.ShootRoomCenter.Price;
                    break;
                case "Nantes":
                    GameViewModel.Current.CitySix.ShootRoomCenter.Quantity++;
                    GameViewModel.Current.CitySix.CityAttractivity += GameViewModel.Current.CitySix.ShootRoomCenter.Attractivity;
                    GameViewModel.Current.Player.PlayerMoney -= GameViewModel.Current.CitySix.ShootRoomCenter.Price;
                    break;

            }
        }

        public static void SetUpCityTaxes(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    if (GameViewModel.Current.CityOne.Taxes >= 0 && GameViewModel.Current.CityOne.Taxes < 50 && GameViewModel.Current.CityOne.CityAttractivity > 0)
                    {
                        GameViewModel.Current.CityOne.Taxes++;
                        GameViewModel.Current.CityOne.CityAttractivity--;
                    }
                    break;
                case "Lorient":
                    if (GameViewModel.Current.CityTow.Taxes >= 0 && GameViewModel.Current.CityTow.Taxes < 50 && GameViewModel.Current.CityTow.CityAttractivity > 0)
                    {
                        GameViewModel.Current.CityTow.Taxes++;
                        GameViewModel.Current.CityTow.CityAttractivity--;
                    }
                    break;
                case "Rennes":
                    if (GameViewModel.Current.CityThree.Taxes >= 0 && GameViewModel.Current.CityThree.Taxes < 50 && GameViewModel.Current.CityThree.CityAttractivity > 0)
                    {
                        GameViewModel.Current.CityThree.Taxes++;
                        GameViewModel.Current.CityThree.CityAttractivity--;
                    }
                    break;
                case "Quimper":
                    if (GameViewModel.Current.CityFour.Taxes >= 0 && GameViewModel.Current.CityFour.Taxes < 50 && GameViewModel.Current.CityFour.CityAttractivity > 0)
                    {
                        GameViewModel.Current.CityFour.Taxes++;
                        GameViewModel.Current.CityFour.CityAttractivity--;
                    }
                    break;
                case "Vannes":
                    if (GameViewModel.Current.CityFive.Taxes >= 0 && GameViewModel.Current.CityFive.Taxes < 50 && GameViewModel.Current.CityFive.CityAttractivity > 0)
                    {
                        GameViewModel.Current.CityFive.Taxes++;
                        GameViewModel.Current.CityFive.CityAttractivity--;
                    }
                    break;
                case "Nantes":
                    if (GameViewModel.Current.CitySix.Taxes >= 0 && GameViewModel.Current.CitySix.Taxes < 50 && GameViewModel.Current.CitySix.CityAttractivity > 0)
                    {
                        GameViewModel.Current.CitySix.Taxes++;
                        GameViewModel.Current.CitySix.CityAttractivity--;
                    }
                    break;
            }
        }

        public static void SetDownCityTaxes(string cityName)
        {
            switch (cityName)
            {
                case "Brest":
                    if (GameViewModel.Current.CityOne.Taxes > 0 && GameViewModel.Current.CityOne.Taxes <= 50)
                    {
                        GameViewModel.Current.CityOne.Taxes--;
                        GameViewModel.Current.CityOne.CityAttractivity++;
                    }
                    break;
                case "Lorient":
                    if (GameViewModel.Current.CityTow.Taxes > 0 && GameViewModel.Current.CityTow.Taxes <= 50)
                    {
                        GameViewModel.Current.CityTow.Taxes--;
                        GameViewModel.Current.CityTow.CityAttractivity++;
                    }
                    break;
                case "Rennes":
                    if (GameViewModel.Current.CityThree.Taxes > 0 && GameViewModel.Current.CityThree.Taxes <= 50)
                    {
                        GameViewModel.Current.CityThree.Taxes--;
                        GameViewModel.Current.CityThree.CityAttractivity++;
                    }
                    break;
                case "Quimper":
                    if (GameViewModel.Current.CityFour.Taxes > 0 && GameViewModel.Current.CityFour.Taxes <= 50)
                    {
                        GameViewModel.Current.CityFour.Taxes--;
                        GameViewModel.Current.CityFour.CityAttractivity++;
                    }
                    break;
                case "Vannes":
                    if (GameViewModel.Current.CityFive.Taxes > 0 && GameViewModel.Current.CityFive.Taxes <= 50)
                    {
                        GameViewModel.Current.CityFive.Taxes--;
                        GameViewModel.Current.CityFive.CityAttractivity++;
                    }
                    break;
                case "Nantes":
                    if (GameViewModel.Current.CitySix.Taxes > 0 && GameViewModel.Current.CitySix.Taxes <= 50)
                    {
                        GameViewModel.Current.CitySix.Taxes--;
                        GameViewModel.Current.CitySix.CityAttractivity++;
                    }
                    break;
            }
        }

        public static void SetPlayerMoney()
        {
            int moneyToAdd = 0;
            moneyToAdd += GameViewModel.Current.CityOne.CityPoepleCount * GameViewModel.Current.CityOne.Taxes;
            moneyToAdd += GameViewModel.Current.CityTow.CityPoepleCount * GameViewModel.Current.CityTow.Taxes;
            moneyToAdd += GameViewModel.Current.CityThree.CityPoepleCount * GameViewModel.Current.CityThree.Taxes;
            moneyToAdd += GameViewModel.Current.CityFour.CityPoepleCount * GameViewModel.Current.CityFour.Taxes;
            moneyToAdd += GameViewModel.Current.CityFive.CityPoepleCount * GameViewModel.Current.CityFive.Taxes;
            moneyToAdd += GameViewModel.Current.CitySix.CityPoepleCount * GameViewModel.Current.CitySix.Taxes;
            GameViewModel.Current.Player.PlayerMoney += moneyToAdd;
        }

        public static void SetPoepleInCity()
        {
            if (GameViewModel.Current.CityOne.CityCapacity > 0 &&
                GameViewModel.Current.CityOne.CityCapacity > GameViewModel.Current.CityOne.CityPoepleCount)
            {
                if ((GameViewModel.Current.CityOne.CityCapacity - GameViewModel.Current.CityOne.CityPoepleCount) <
                    GameViewModel.Current.CityOne.CityAttractivity)
                {
                    GameViewModel.Current.CityOne.CityPoepleCount = GameViewModel.Current.CityOne.CityCapacity;
                }
                else
                {
                    GameViewModel.Current.CityOne.CityPoepleCount += GameViewModel.Current.CityOne.CityAttractivity;
                }
            }

            if (GameViewModel.Current.CityTow.CityCapacity > 0 &&
                GameViewModel.Current.CityTow.CityCapacity > GameViewModel.Current.CityTow.CityPoepleCount)
            {
                if ((GameViewModel.Current.CityTow.CityCapacity - GameViewModel.Current.CityTow.CityPoepleCount) <
                    GameViewModel.Current.CityTow.CityAttractivity)
                {
                    GameViewModel.Current.CityTow.CityPoepleCount = GameViewModel.Current.CityTow.CityCapacity;
                }
                else
                {
                    GameViewModel.Current.CityTow.CityPoepleCount += GameViewModel.Current.CityTow.CityAttractivity;
                }
            }

            if (GameViewModel.Current.CityThree.CityCapacity > 0 &&
                GameViewModel.Current.CityThree.CityCapacity > GameViewModel.Current.CityThree.CityPoepleCount)
            {
                if ((GameViewModel.Current.CityThree.CityCapacity - GameViewModel.Current.CityThree.CityPoepleCount) <
                    GameViewModel.Current.CityThree.CityAttractivity)
                {
                    GameViewModel.Current.CityThree.CityPoepleCount = GameViewModel.Current.CityThree.CityCapacity;
                }
                else
                {
                    GameViewModel.Current.CityThree.CityPoepleCount += GameViewModel.Current.CityThree.CityAttractivity;
                }
            }

            if (GameViewModel.Current.CityFour.CityCapacity > 0 &&
                GameViewModel.Current.CityFour.CityCapacity > GameViewModel.Current.CityFour.CityPoepleCount)
            {
                if ((GameViewModel.Current.CityFour.CityCapacity - GameViewModel.Current.CityFour.CityPoepleCount) <
                    GameViewModel.Current.CityFour.CityAttractivity)
                {
                    GameViewModel.Current.CityFour.CityPoepleCount = GameViewModel.Current.CityFour.CityCapacity;
                }
                else
                {
                    GameViewModel.Current.CityFour.CityPoepleCount += GameViewModel.Current.CityFour.CityAttractivity;
                }
            }

            if (GameViewModel.Current.CityFive.CityCapacity > 0 &&
                GameViewModel.Current.CityFive.CityCapacity > GameViewModel.Current.CityFive.CityPoepleCount)
            {
                if ((GameViewModel.Current.CityFive.CityCapacity - GameViewModel.Current.CityFive.CityPoepleCount) <
                    GameViewModel.Current.CityFive.CityAttractivity)
                {
                    GameViewModel.Current.CityFive.CityPoepleCount = GameViewModel.Current.CityFive.CityCapacity;
                }
                else
                {
                    GameViewModel.Current.CityFive.CityPoepleCount += GameViewModel.Current.CityFive.CityAttractivity;
                }
            }

            if (GameViewModel.Current.CitySix.CityCapacity > 0 &&
                GameViewModel.Current.CitySix.CityCapacity > GameViewModel.Current.CityThree.CityPoepleCount)
            {
                if ((GameViewModel.Current.CitySix.CityCapacity - GameViewModel.Current.CitySix.CityPoepleCount) <
                    GameViewModel.Current.CitySix.CityAttractivity)
                {
                    GameViewModel.Current.CitySix.CityPoepleCount = GameViewModel.Current.CitySix.CityCapacity;
                }
                else
                {
                    GameViewModel.Current.CitySix.CityPoepleCount += GameViewModel.Current.CitySix.CityAttractivity;
                }
            }
            GameViewModel.Current.Player.PlayerPoepleCount = GameViewModel.Current.CityOne.CityPoepleCount +
                                                             GameViewModel.Current.CityTow.CityPoepleCount +
                                                             GameViewModel.Current.CityThree.CityPoepleCount +
                                                             GameViewModel.Current.CityFour.CityPoepleCount +
                                                             GameViewModel.Current.CityFive.CityPoepleCount +
                                                             GameViewModel.Current.CitySix.CityPoepleCount;
        }

        public static void ResetGameModel()
        {
            GameViewModel.Current.Player.PlayerMoney = 100000;
            GameViewModel.Current.Player.PlayerPoepleCount = 0;
            GameViewModel.Current.CityOne = new CityModel
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

            GameViewModel.Current.CityTow = new CityModel
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

            GameViewModel.Current.CityThree = new CityModel
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

            GameViewModel.Current.CityFour = new CityModel
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

            GameViewModel.Current.CityFive = new CityModel
            {
                CityName = "Vannes",
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
                ImagePath = "../Content/Images/Vannes.JPG"
            };

            GameViewModel.Current.CitySix = new CityModel
            {
                CityName = "Nantes",
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
                ImagePath = "../Content/Images/Nantes.JPG"
            };
        }
    }
}


/*
 
                 case "Brest":
                    break;
                case "Lorient":
                    break;
                case "Rennes":
                    break;
                case "Quimper":
                    break;
                case "Vannes":
                    break;
                case "Nantes":
                    break;
 */