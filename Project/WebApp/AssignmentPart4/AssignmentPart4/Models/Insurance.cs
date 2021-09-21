using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentPart4.Models
{
    public class Insurance
    {
       
        public int InsuranceID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string CarName { get; set; }
        public string CarModel { get; set; }

        public int CarYear { get; set; }

        public int SpeedingTicket { get; set; }

        public bool DUI { get; set; }

        public bool FullCoverage { get; set; }
        public double Base { get; set; }
    }
}