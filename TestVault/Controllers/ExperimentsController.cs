using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Json;
using TestVault.Models;

namespace TestVault.Controllers
{
    public class ExperimentsController : ApiController
    {
        public HttpResponseMessage<Experiment> GetByNumber(int number)
        {
            Experiment exp = new Experiment();
            exp.Name = "Example Experiment";
            exp.Number = number;
            exp.Purpose = "Development";
            exp.WhenCreated = DateTime.Now;
            exp.WhenUpdated = DateTime.Now;
            exp.WhoUpdated = "lemmej1";
            exp.Documents = new List<Document>();
            exp.Schedules = new List<String>();
            exp.FactorLevels = new List<FactorLevel>();
            exp.Components = new List<Component>();

            FactorLevel f1 = new FactorLevel();
            f1.Factor = "Discharge Rate";
            f1.Description = "Slow";
            f1.Level = "5 mA";

            exp.FactorLevels.Add(f1);

            FactorLevel f2 = new FactorLevel();
            f2.Factor= "Discharge Rate";
            f2.Description = "Fast";
            f2.Level = "10 mA";

            exp.FactorLevels.Add(f2);

            Document doc1 = new Document();
            doc1.Number = "R123456";
            doc1.Role = "Test Plan";
            doc1.Author = "Lemmerman, Jeffrey";
            doc1.Link = "http://docurl.com/R123456";
            doc1.Title = "My Test Plan";

            exp.Documents.Add(doc1);

            Document doc2 = new Document();
            doc2.Number = "R123457";
            doc2.Role = "Report";
            doc2.Author = "Lemmerman, Jeffrey";
            doc2.Link = "http://docurl.com/R123457";
            doc2.Title = "My Test Report";

            exp.Documents.Add(doc2);

            exp.Schedules.Add(number.ToString() + "-1");
            exp.Schedules.Add(number.ToString() + "-2");
            exp.Schedules.Add(number.ToString() + "-3");

            Component comp1 = new Component();
            comp1.Id = 1;
            comp1.SerialNumber = "1-001";
            comp1.Type = "Battery";

            exp.Components.Add(comp1);

            var response = new HttpResponseMessage<Experiment>(exp, HttpStatusCode.OK);
            return response;
        }
    }
}