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

            var response = new HttpResponseMessage<Experiment>(exp, HttpStatusCode.OK);
            return response;
        }
    }
}