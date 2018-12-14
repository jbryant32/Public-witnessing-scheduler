using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class AlertViewModel:ModelBase
    {
        ObservableCollection<AlertPageGroupItem> _AlertListItems = new ObservableCollection<AlertPageGroupItem>();
        public ObservableCollection<AlertPageGroupItem> AlertListItems { get => _AlertListItems; set => _AlertListItems = value; }
        ICommand _AlertTappedCommand;
        public ICommand AlertTappedCommand { get => _AlertTappedCommand; set { OnPropertyChanging(); _AlertTappedCommand = value; OnPropertyChanged(); } }
        public AlertViewModel()
        {
         
            AlertTappedCommand = new Command(OnAlertTapped);
            var ListNew = new AlertPageGroupItem()
            {
                    new AlertPageItem(){ Content="New Booking For Palm Desert Shopping Mall" , Status="New",Title="New Booking" },
                    new AlertPageItem(){ Content="New Booking For El Paseo Shopping Center" ,Status="New",Title="New Booking" }
              
            };
            ListNew.Heading = "New";

            var ListOld = new AlertPageGroupItem()
            {
               
                    new AlertPageItem(){ Content="Booking Updated For Palm Desert Shopping Mall"  ,Status="Old",Title="Booking" },
           
            };
            ListOld.Heading = "Old";
            AlertListItems.Add(ListNew);
            AlertListItems.Add(ListOld);
 
        }

        private async void OnAlertTapped(object alert)
        {
            var _alert = alert as AlertPageItem;
            await Application.Current.MainPage.Navigation.PushModalAsync(new AlertInfoPage(_alert));

        }
    }
}
