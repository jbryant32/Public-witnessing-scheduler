using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.EventTriggers
{
    public class AlertItemTappedTrigger : TriggerAction<ViewCell>
    {
        protected override void Invoke(ViewCell sender)
        {
            var Context = sender.BindingContext;

        }
    }
}
