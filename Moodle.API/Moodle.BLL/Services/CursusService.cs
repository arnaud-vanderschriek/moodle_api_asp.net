using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.BLL.Services
{
    public class CursusService(ICursusRepository _cursusRepository)
    {
        public List<Cursus> Get()
        {
            return _cursusRepository.FindAll();
        }
    
        public Cursus Get(int id)
        {
            return _cursusRepository.Find(id);
        }

        public Cursus AddCursus(string name, DateTime startDate, DateTime endDate)
        {
            Cursus cursus = new Cursus() { Name = name, startDate = startDate, endDate = endDate };
            return _cursusRepository.Add(cursus);
        }

        public void Del(int id)
        {

        }
    }
}
