using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageGalleryModalTemplate : ContentPage
	{
        ObservableCollection<MediaGalleryItem> _GalleryItem = new ObservableCollection<MediaGalleryItem>();
        public ObservableCollection<MediaGalleryItem> GalleryItem  { get=>_GalleryItem; set { _GalleryItem = value; } }
        Command _ImageTapped;
        public Command ImageTapped { get { return _ImageTapped ?? new Command<string>(OpenImage); } set { _ImageTapped = value; } }
        public ImageGalleryModalTemplate()
        {
            InitializeComponent();
          
        }

        protected override void OnAppearing()
        {
            //GalleryItem.Add(new MediaGalleryItem() { ImageSource = "cart_jw.jpg", Caption = "This is the location Setup for the airport" });
            //GalleryItem.Add(new MediaGalleryItem() { ImageSource = "jw_cta.jpg", Caption = "This is the location Setup for the airport" });
            //GalleryItem.Add(new MediaGalleryItem() { ImageSource = "witnesses.jpg", Caption = "This is the location Setup for the airport" });
             
            //this.ItemsSource = GalleryItem;
           
            base.OnAppearing();
        }
        private void OpenImage(string Source) {
            //if image width > length rotate else keep in place
        }

    }
}