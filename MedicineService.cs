using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Service.Services;

namespace WPF.Hospital.Service
{
    public class MedicineService : IMedicineService
    {
        public (bool Ok, string Message) Create(Medicine medicine)
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Medicine? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Update(Medicine medicine)
        {
            throw new NotImplementedException();
        }
    }
}
