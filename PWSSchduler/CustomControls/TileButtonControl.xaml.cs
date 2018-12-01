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
	public partial class TileButtonControl : ContentView
	{
        TapGestureRecognizer TapGesture { get; set; }
        public string Icon { get => (string)GetValue(IconProperty); set { SetValue(IconProperty, value); } }
        public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(TileButtonControl), "", BindingMode.TwoWay);

        public Command OnButtonClick { get => (Command)GetValue(OnButtonClickProperty); set => SetValue(OnButtonClickProperty, value); }
        public static readonly BindableProperty OnButtonClickProperty = BindableProperty.Create(nameof(OnButtonClick), typeof(Command), typeof(TileButtonControl), null, BindingMode.TwoWay);

        public string ButtonText { get => (string)GetValue(ButtonTextProperty); set => SetValue(ButtonTextProperty, value); }
        public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(TileButtonControl), null, BindingMode.TwoWay);

        public TileButtonControl ()
		{
			InitializeComponent ();
            this.Content.BindingContext = this;
            this.TapGesture = new TapGestureRecognizer();
            this.TapGesture.Tapped += TapGesture_Tapped;
            this.GestureRecognizers.Add(this.TapGesture);
		}

      

         

        //public Command TapCommand { get => (Command)GetValue(TapCommandProperty); set => SetValue(TapCommandProperty, value); }
        //public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(nameof(TapCommand), typeof(Command), typeof(ButtonContentView), null, BindingMode.TwoWay);

        

       
       

        private async void TapGesture_Tapped(object sender, EventArgs e)
        {
            await this.ScaleTo(0.95, 50, Easing.CubicOut);
            await this.ScaleTo(1, 50, Easing.CubicIn);
        }

    }
}