using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _213002_Final.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }

        //Navigation Properties
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

    }
}