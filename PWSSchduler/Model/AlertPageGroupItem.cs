using System;
using System.Collections.Generic;
using System.Text;

namespace PWSSchduler.Model
{
    public class AlertPageGroupItem:List<AlertPageItem>
    {
        public string Heading { get; set; }
        public List<AlertPageItem> AlertList => this;
    }
}
