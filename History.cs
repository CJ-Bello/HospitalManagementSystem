using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Hospital.Model
{
    public class History
    {
        public int Id { get; set; }
        public Patient PatientId { get; set; }
        public Doctor DoctorId { get; set; }
        public string Procedure { get; set; }
    }
}
