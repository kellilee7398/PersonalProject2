using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalProject2.Models
{
    public class Study
    {
        public int CsnNumber { get; set; }
        public string PhysicianID { get; set; }
        public int PatientID { get; set; }
        public int EpworthScale { get; set; }
        public int StopBangScale { get; set; }
        public string ScorerUserID { get; set; }
        public string DateScored { get; set; }
        public string DateDictated { get; set; }
        public int DmeID { get; set; }

    }
}
