using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class Step
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string ControlMode { get; set; }
        public decimal SetPoint { get; set; }
    }
}