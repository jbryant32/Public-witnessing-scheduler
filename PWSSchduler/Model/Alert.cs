using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.Model
{
    public class Alert : ModelBase
    {
        public string _GID;
        public string GID { get => _GID; set => _GID = value; }
        string _Status;
        public string Status { get => _Status; set { OnPropertyChanging(); _Status = value; OnPropertyChanged(); } }
        string _Condition;
        public string Condition { get => _Condition; set { OnPropertyChanging(); _Condition = value; OnPropertyChanged(); } }
        string _Title;
        public string Title { get => _Title; set { OnPropertyChanging(); _Title = value; OnPropertyChanged(); } }
        string _Content;
        public string Content { get => _Content; set { OnPropertyChanging(); _Content = value; OnPropertyChanged(); } }

        public Alert()
        {

        }
    }
}
