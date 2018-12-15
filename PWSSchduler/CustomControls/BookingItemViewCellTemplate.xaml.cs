using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookingItemViewCellTemplate : ViewCell
	{
        public ICommand ViewCellCommand { get=>(Command)GetValue(ViewCellCommandProperty); set { SetValue(ViewCellCommandProperty, value); } }
        public static readonly BindableProperty ViewCellCommandProperty = BindableProperty.Create(nameof(ViewCellCommand), typeof(Command), typeof(BookingItemViewCellTemplate), null);
		public BookingItemViewCellTemplate ()
		{
			InitializeComponent ();
		}

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            //ViewCellCommand.Execute(this.BindingContext);
        }
    }
}