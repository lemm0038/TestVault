using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class Document
    {
        public string Number { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Role { get; set; }
        public string Link { get; set; }
    }
}