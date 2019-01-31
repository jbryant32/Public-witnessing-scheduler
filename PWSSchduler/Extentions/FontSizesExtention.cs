using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Extentions
{
    [ContentProperty(nameof(SizeRequested))]
    public class FontSizesExtention : IMarkupExtension
    {
        public enum Size {
            Standard,Medium ,Large,Title
        }
        public Size SizeRequested { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            switch (SizeRequested)
            {
                case Size.Standard:
                    return new FontSizeConverter().ConvertFromInvariantString("24");
                case Size.Medium:
                    return new FontSizeConverter().ConvertFromInvariantString("32");
                case Size.Large:
                    return new FontSizeConverter().ConvertFromInvariantString("40");
                case Size.Title:
                    return new FontSizeConverter().ConvertFromInvariantString("48");
                default:
                    return new FontSizeConverter().ConvertFromInvariantString("24");
            }
        }
    }
}
