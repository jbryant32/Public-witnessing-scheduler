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
    public partial class BaseContentViewTemplate : ContentView
    {
        public bool isActive {get=>(bool)GetValue(isActiveProperty);set { SetValue(isActiveProperty, value); } }
        public static readonly BindableProperty isActiveProperty = BindableProperty.Create(nameof(isActive), typeof(bool), typeof(BaseContentViewTemplate), true);
        public bool isActiveRunning { get=>(bool)GetValue(isActiveRunningProperty); set=>SetValue(isActiveRunningProperty,value); }
        public static readonly BindableProperty isActiveRunningProperty = BindableProperty.Create(nameof(isActiveRunning), typeof(bool), typeof(BaseContentViewTemplate), true);

        public BaseContentViewTemplate()
		{
         
			InitializeComponent ();
		}
	}
}