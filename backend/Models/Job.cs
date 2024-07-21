using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string JobDescription { get; set; } = string.Empty;
        public int Cost { get; set; }
        public int Sell { get; set; }
        public decimal GrossProfit { get; set; }
        public string JobStatus { get; set; } = "Pending";
        public string Priority { get; set; } = "Medium";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public string Comments { get; set; } = string.Empty;

        public int? UserId { get; set; } // Navigation property
        public User? User { get; set; }

    }
}