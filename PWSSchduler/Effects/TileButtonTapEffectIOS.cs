using PWSSchduler.IOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

 [assembly: ExportEffect(typeof(TileButtonTapEffect), "TapEffect")]
namespace PWSSchduler.IOS
{
    public class TileButtonTapEffect : PlatformEffect<Grid, BoxView>
    {
        protected override void OnAttached()
        {

        }

        protected override void OnDetached()
        {

        }
    }
}
