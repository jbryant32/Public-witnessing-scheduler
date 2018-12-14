using System;
using System.Collections.Generic;
using System.Text;

namespace PWSSchduler.Model
{
    public class AlertPageGroupItem:List<Alert>
    {
        public string Heading { get; set; }
        public List<Alert> AlertList => this;
    }
}
