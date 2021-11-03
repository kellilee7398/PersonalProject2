using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalProject2.Models
{
    public class Physician
    {
        public string PhysicianID { get; set; }
        public string PhysicianFirstName { get; set; }
        public string PhysicianLastName { get; set; }
        public int PhysicianOfficeID { get; set; }
        public string PhysicianPersonalPhone { get; set; }
        public string PhysicianSpecialty { get; set; }
    }
}
