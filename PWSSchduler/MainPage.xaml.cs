using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PWSSchduler
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.MasterPageInstance.ListViewPageLinks.ItemSelected += ListViewPageLinks_ItemSelected;
        }
      
        private void ListViewPageLinks_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as MasterPageItem;
            if (Item != null)
            {
                Detail = (new NavigationPage((Page)Activator.CreateInstance(Item.ContentPageItem)));
                this.MasterPageInstance.ListViewPageLinks.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
