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
    public class SchedulesController : ApiController
    {

        public HttpResponseMessage<Schedule> GetById(string Id)
        {
            Schedule sched1 = new Schedule();
            sched1.Steps = new List<Step>();
            sched1.Tasks = new List<Task>();
            sched1.Description = "Example Schedule";
            sched1.EndDate = DateTime.Now.AddDays(1);
            sched1.PlannedEndDate = DateTime.Now.AddDays(1);
            sched1.PlannedStartDate = DateTime.Now;
            sched1.ScheduleId = Id;
            sched1.StartDate = DateTime.Now;
            sched1.Status = "Active";
            sched1.WhenSubmitted = DateTime.Now;
            sched1.WhoSubmitted = "lemmej1";
            sched1.WhoApproved = "chimenm1";
            sched1.WhenApproved = DateTime.Now;

            Task task1 = new Task();
            task1.Number = 1;
            task1.Description = "Incoming Inspection";
            task1.Duration = 0.1M;
            task1.IsComplete = false;
            task1.PlannedDate = DateTime.Now;

            Step step1 = new Step();
            step1.StepCriteria = new List<StepCriteria>();
            step1.Name = "50 mA Charge";
            step1.ControlMode = "Current(A)";
            step1.SetPoint = 0.050M;
            step1.Number = 2;
            step1.StepCriteria.Add(new StepCriteria("Voltage >= 4.075", "Next"));
            step1.StepCriteria.Add(new StepCriteria("DeltaVoltage >= 0.020", "Log"));
            step1.StepCriteria.Add(new StepCriteria("DeltaStepTime >= 10.0", "Log"));

            Step step2 = new Step();
            step2.StepCriteria = new List<StepCriteria>();
            step2.Name = "4.075 V Hold";
            step2.ControlMode = "Voltage(V)";
            step2.SetPoint = 4.075M;
            step2.Number = 3;
            step2.StepCriteria.Add(new StepCriteria("StepTime >= 3600", "Next"));
            step2.StepCriteria.Add(new StepCriteria("DeltaStepTime >= 10.0", "Log"));

            Step step3 = new Step();
            step3.StepCriteria = new List<StepCriteria>();
            step3.Name = "50 mA Discharge";
            step3.ControlMode = "Current(A)";
            step3.SetPoint = -0.050M;
            step3.Number = 4;
            step3.StepCriteria.Add(new StepCriteria("Voltage <= 3.0", "Next"));
            step3.StepCriteria.Add(new StepCriteria("DeltaVoltage >= 0.020", "Log"));
            step3.StepCriteria.Add(new StepCriteria("DeltaStepTime >= 10.0", "Log"));

            Task task2 = new Task();
            task2.Number = 5;
            task2.Description = "Remove from test";
            task2.Duration = 0.1M;
            task2.IsComplete = false;
            task2.PlannedDate = DateTime.Now.AddDays(7);

            sched1.Steps.Add(step1);
            sched1.Steps.Add(step2);
            sched1.Steps.Add(step3);
            sched1.Tasks.Add(task1);
            sched1.Tasks.Add(task2);

            var response = new HttpResponseMessage<Schedule>(sched1, HttpStatusCode.OK);
            return response;
        }

    }
}
