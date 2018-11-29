using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.EventTriggers
{
    public class EventTriggerInvoke : TriggerAction<Entry>
    {
       public Action Method { get; set; }
        public static readonly BindableProperty MethodProperty = BindableProperty.Create(nameof(Method), typeof(void), typeof(EventTriggerInvoke), null);

        protected override void Invoke(Entry sender)
        {
            Method();
        }
    }
}
