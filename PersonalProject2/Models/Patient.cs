using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalProject2.Models
{
    public class Patient
    {
        public int MedRecordNumber { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhone { get; set; }
        public string PatientBirthdate { get; set; }
        public int PatientAge { get; set; }
                     
    }
}
