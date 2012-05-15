using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class ComponentProperty
    {
        public string key { get; set; }
        public string value { get; set; }

        public ComponentProperty()
        {
        }

        public ComponentProperty(string newKey, string newValue)
        {
            key = newKey;
            value = newValue;
        }
    }
}