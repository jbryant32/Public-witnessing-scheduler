using PWSSchduler.Droid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform;

[assembly: ResolutionGroupName("VirtualHavenStudios")]
[assembly: ExportEffect(typeof(TileButtonTapEffect), "TapEffect")]
namespace PWSSchduler.Droid
{
    public class TileButtonTapEffect : PlatformEffect<BoxView, TapGestureRecognizer>
    {
        protected override void OnAttached()
        {
             
        }

        protected override void OnDetached()
        {
           
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            var PropertyName = args.PropertyName;
            base.OnElementPropertyChanged(args);
        }
    }


}

