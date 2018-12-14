using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.Model
{
    public class AlertPageItem:ModelBase
    {
        string _Status;
        public string Status { get =>_Status; set { OnPropertyChanging();_Status = value; OnPropertyChanged(); } }
        string _Title;
        public string Title { get => _Title; set { OnPropertyChanging(); _Title = value; OnPropertyChanged(); } }
        string _Content;
        public string Content { get => _Content; set { OnPropertyChanging();_Content = value; OnPropertyChanged(); } }
      
        public AlertPageItem()
        {

        }
    }
}
