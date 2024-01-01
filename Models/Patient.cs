using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _213002_Final.Models
{
    public class Patient
    {
        public int PatientID {  get; set; }
        public string PatientName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}