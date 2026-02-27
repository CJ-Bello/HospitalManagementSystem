using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;
using WPF.Hospital.Repository.Interface;

namespace WPF.Hospital.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly HospitalDbContext _context;
        public PatientRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public void Add(Patient entity)
        {
            _context.Patients.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Patients.Remove();
            _context.SaveChanges();
        }

        public Patient? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            _context.SaveChanges();

        }

        public void Update(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}
