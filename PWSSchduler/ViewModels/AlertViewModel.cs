using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PWSSchduler.ViewModels
{
    public class AlertViewModel
    {
        ObservableCollection<AlertPageGroupItem> _AlertListItems = new ObservableCollection<AlertPageGroupItem>();
        public ObservableCollection<AlertPageGroupItem> AlertListItems { get => _AlertListItems; set => _AlertListItems = value; }
        public AlertViewModel()
        {
            var ListNew = new AlertPageGroupItem()
            {
                    new AlertPageItem(){ Content="New Booking For Palm Desert Shopping Mall" ,isPrestene=true,Title="New Booking" },
                    new AlertPageItem(){ Content="New Booking For El Paseo Shopping Center",isPrestene=true,Title="New Booking" }
              
            };
            ListNew.Heading = "New";

            var ListOld = new AlertPageGroupItem()
            {
               
                    new AlertPageItem(){ Content="Booking Updated For Palm Desert Shopping Mall" ,isPrestene=true,Title="Booking" },
           
            };
            ListOld.Heading = "Old";
            AlertListItems.Add(ListNew);
            AlertListItems.Add(ListOld);
        }
    }
}
