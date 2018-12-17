
using System;
using System.Linq;
using System.Reflection;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PWSSchduler.Extentions
{
    [ContentProperty(nameof(Member))]
    public class FontAwesomeIconsExtention : IMarkupExtension
    {
        public string Member { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            switch (Member)
            {
                case "Map":
                    return "\uf5a0";
                case "Bell":
                    return "\uf0f3";
                default:
                    return "";
            }
        }
    }
}
