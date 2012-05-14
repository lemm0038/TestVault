using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }
        public List<KeyValuePair<string, string>> Properties { get; set; }
    }
}