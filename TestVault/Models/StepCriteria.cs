using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class StepCriteria
    {
        public string Criteria { get; set; }
        public string Action { get; set; }

        public StepCriteria()
        {
        }
        public StepCriteria(string newCriteria, string newAction)
        {
            Criteria = newCriteria;
            Action = newAction;
        }
    }
}