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
	public partial class TileButtonTemplated : ContentView
	{
        public  Command ButtonClicked { get => (Command)GetValue(ButtonClickedProperty); set => SetValue(ButtonClickedProperty, value); }
        public static readonly BindableProperty ButtonClickedProperty = BindableProperty.Create(nameof(ButtonClicked), typeof(Command), typeof(TileButtonTemplated), null);
        public string IconString { get=>(string)GetValue(IconStringProperty); set=>SetValue(IconStringProperty,value); }
        public static readonly BindableProperty IconStringProperty = BindableProperty.Create(nameof(IconString), typeof(string), typeof(TileButtonTemplated), null);
        public string ButtonTitle { get=>(string)GetValue(ButtonTileProperty); set=>SetValue(ButtonTileProperty,value); }
        public static readonly BindableProperty ButtonTileProperty = BindableProperty.Create(nameof(ButtonTitle), typeof(string), typeof(TileButtonTemplated), "");
		public TileButtonTemplated ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (ButtonClicked != null) {
                ButtonClicked.Execute(sender);
            }
        }
    }
}