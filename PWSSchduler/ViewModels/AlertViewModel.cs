using PWSSchduler.Model;
using PWSSchduler.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PWSSchduler.ViewModels
{
    public class AlertViewModel : ModelBase
    {
        ObservableCollection<AlertPageGroupItem> _AlertListItems = new ObservableCollection<AlertPageGroupItem>();
        public ObservableCollection<AlertPageGroupItem> AlertListItems { get => _AlertListItems; set { OnPropertyChanging(); _AlertListItems = value; OnPropertyChanged(); } }
        ICommand _AlertTappedCommand;
        public ICommand AlertTappedCommand { get => _AlertTappedCommand; set { OnPropertyChanging(); _AlertTappedCommand = value; OnPropertyChanged(); } }
        public AlertViewModel()
        {
            AlertTappedCommand = new Command(OnAlertTapped);
            
        }
        public async override Task Init()
        {
            var Results = await DataStore.GetAlerts();
            var ListNew = new AlertPageGroupItem();
            ListNew.AddRange(Results.Where((a) => a.Status == "New"));
            ListNew.Heading = "New";

            var ListOld = new AlertPageGroupItem();
            ListOld.AddRange(Results.Where((a) => a.Status == "Old"));
            ListOld.Heading = "Old";

            AlertListItems.Add(ListNew);
            AlertListItems.Add(ListOld);
            await base.Init();
        }
        private async void OnAlertTapped(object alert)
        {
            var _alert = alert as Alert;
            _alert.Condition = "Opened";
            await Application.Current.MainPage.Navigation.PushModalAsync(new AlertInfoPage(_alert));
        }
    }
}
