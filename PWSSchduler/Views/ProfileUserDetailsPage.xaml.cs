using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileUserDetailsPage : ContentPage
	{
        public ProfilePageItem UserProfileInfo { get; set; }
        public ProfileUserDetailsPage(ProfilePageItem profile)
        {
            InitializeComponent();
        }
		public ProfileUserDetailsPage ()
		{
			InitializeComponent ();
		}
	}
}