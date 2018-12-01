using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.Styles
{
    public class TileButton : BindableObject
    {
        public string Icon { get => (string)GetValue(IconProperty); set { SetValue(IconProperty, value); } }
        public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(TileButton), "");
        public Command OnButtonClick { get => (Command)GetValue(OnButtonClickProperty); set => SetValue(OnButtonClickProperty, value); }
        public static readonly BindableProperty OnButtonClickProperty = BindableProperty.Create(nameof(OnButtonClick), typeof(Command), typeof(TileButton), null);
        public string ButtonText { get; set; }
     }

    
}
