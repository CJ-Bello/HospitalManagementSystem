using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Hospital.Model
{
    public class Prescription
    {
        public int Id { get; set; }
        public History HistoryId { get; set; }
        public Medicine MedicineId { get; set; }
        public int Quantity { get; set; }
        public string Frequency { get; set; }
    }
}
