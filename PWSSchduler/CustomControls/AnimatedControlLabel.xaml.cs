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
	public partial class AnimatedControlLabel : ContentView
	{
		public AnimatedControlLabel ()
		{
			InitializeComponent ();
		}
	}
}