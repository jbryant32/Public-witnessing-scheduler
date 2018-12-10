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
	public partial class HomeViewTemplate : ContentView
	{
        public Command TapCommand { get => (Command)GetValue(TapCommandProperty); set => SetValue(TapCommandProperty,value); }
        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(nameof(TapCommand), typeof(Command), typeof(HomeViewTemplate), null);
		public HomeViewTemplate ()
		{
			InitializeComponent ();
		}
	}
}