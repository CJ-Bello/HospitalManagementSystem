using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Hospital.Model;

namespace WPF.Hospital.Repository
{
    public class HistoryRepository : IHistoryRepository
    {
        public void Add(History entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public History? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<History> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<History> GetByPatient(int historyId)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(History entity)
        {
            throw new NotImplementedException();
        }
    }
}
