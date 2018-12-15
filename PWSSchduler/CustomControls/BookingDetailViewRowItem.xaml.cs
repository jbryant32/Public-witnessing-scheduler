using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingDetailViewRowItem : ContentView
    {

        public string Title{get=>(string)GetValue(TitleProperty);set=>SetValue(TitleProperty,value);}
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(BookingDetailViewRowItem), "");
        public string Info { get=>(string)GetValue(InfoProperty); set=>SetValue(InfoProperty,value); }
        public static readonly BindableProperty InfoProperty = BindableProperty.Create(nameof(Info), typeof(string), typeof(BookingDetailViewRowItem), "");
        public BookingDetailViewRowItem ()
		{
            
			InitializeComponent ();
		}
	}
}