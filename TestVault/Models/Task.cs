using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class Task
    {
        public int Number;
        public string Description;
        public Boolean IsComplete;
        public DateTime PlannedDate;
        public DateTime CompletedDate;
        public Decimal Duration;
    }
}