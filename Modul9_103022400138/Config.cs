using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400138
{
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public Confirmation confirmation { get; set; }

        public List<string> methods { get; set; }
        public Config() { }
        public Config(string lang, Transfer transfer, Confirmation confirmation, List<string> methods)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.confirmation = confirmation;
            this.methods = methods;
        }
    }
}
