using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.Behaviors
{
    public class ValidateEmail : Behavior<Entry>
    {
       
        protected override void OnAttachedTo(Entry e)
        {
            e.TextChanged += E_TextChanged;
            base.OnAttachedTo(e);
        }

        private void E_TextChanged(object sender, TextChangedEventArgs e)
        {
            var EntryText = e.NewTextValue;
            var EntryElment = ((Entry)sender);
          
            //try
            //{
            //    MailAddress m = new MailAddress(EntryText);

            //    EntryElment.TextColor = Color.Black;
            //}
            //catch (FormatException)
            //{
            //    EntryElment.TextColor = Color.Red;
            //}

        }

        protected override void OnDetachingFrom(Entry e)
        {
            e.TextChanged -= E_TextChanged;
            base.OnDetachingFrom(e);
            // Perform clean up
        }
    }
}
