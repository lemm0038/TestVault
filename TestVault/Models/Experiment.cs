using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestVault.Models;

namespace TestVault.Models
{
    public class Experiment
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public List<Document> Documents { get; set; }
        public List<String> Schedules { get; set; }
        public List<FactorLevel> FactorLevels { get; set; }
        public List<Component> Components { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenUpdated { get; set; }
        public string WhoUpdated { get; set; }
    }
}