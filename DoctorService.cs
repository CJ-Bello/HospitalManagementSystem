using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Service.Services;

namespace WPF.Hospital.Service
{
    public class DoctorService : IDoctorService
    {
        public (bool Ok, string Message) Create(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Update(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
