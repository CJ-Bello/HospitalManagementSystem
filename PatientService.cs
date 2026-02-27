using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Service.Services;

namespace WPF.Hospital.Service
{
    public class PatientService : IPatientService
    {
        public (bool Ok, string Message) Create(Patient patient)
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Patient? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool Ok, string Message) Update(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
