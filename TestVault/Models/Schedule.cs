using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestVault.Models
{
    public class Schedule
    {
        public string ScheduleId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime WhenSubmitted { get; set; }
        public DateTime WhenApproved { get; set; }
        public string WhoSubmitted { get; set; }
        public string WhoApproved { get; set; }
        public List<Step> Steps { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
