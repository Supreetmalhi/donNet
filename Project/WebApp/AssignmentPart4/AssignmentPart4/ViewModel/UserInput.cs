using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentPart4.ViewModel
{
    public class UserInput
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+", ErrorMessage = "Name only contain alphabetic and space")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]+", ErrorMessage = "Name only contain alphabetic and space")]
        public string LastName { get; set; }
        
        [Required]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Email is not in correct format")]
        public string Email { get; set; }
        
        [Required]
        [Range(1, 110, ErrorMessage = "Age must be between 1 and 110")]
        public int Age { get; set; }

        [Required]
        public string CarName { get; set; }
        [Required]
        public string CarModel { get; set; }

        [Required]
        [Range(1970, 2021, ErrorMessage = "Car Year must be between 1970 and 2021")]
        public int CarYear { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "SpeedingTicket must be between 0 and 100")]
        public int SpeedingTicket { get; set; }

        [Required]
        public bool DUI { get; set; }

        [Required]
        public bool FullCoverage { get; set; }

    }
}