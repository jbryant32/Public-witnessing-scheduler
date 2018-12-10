using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PWSSchduler
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.MasterPageInstance.ListViewPageLinks.ItemTapped += ListViewPageLinks_ItemTapped; ;
        }

        private async void ListViewPageLinks_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Item = e.Item as MasterPageItem;
            if (Item != null)
            {
                await this.Detail.Navigation.PushAsync((Page)Activator.CreateInstance(Item.ContentPageItem));
                this.MasterPageInstance.ListViewPageLinks.SelectedItem = null;
                IsPresented = false;
            }
        }
 
    }
}
