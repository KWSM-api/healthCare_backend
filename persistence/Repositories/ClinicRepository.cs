using application.contracts;
using application.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence.Repositories
{
    public class ClinicRepository : IClinicRepository
    {   
        private readonly AppDbContext _appDbContext;

        public ClinicRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Clinic Create(Clinic clinic)
        {
            _appDbContext.Add(clinic);
            _appDbContext.SaveChanges();

            return clinic;
        }

        public bool Delete(int id)
        {
           _appDbContext.Remove(new Clinic { Id = id});
           _appDbContext.SaveChanges ();

            return true;
        }

        public ICollection<Clinic> GetAll()
        {
           var clinics = _appDbContext.Clinics.ToList();
            return clinics;
        }

        public Clinic GetById(int id)
        {
            var clinic = _appDbContext.Clinics.Where(c => c.Id == id).SingleOrDefault();

            return clinic;
        }

        public Clinic Update(Clinic clinic)
        {
            _appDbContext.Update(clinic);
            _appDbContext.SaveChanges();

            return clinic;
        }
    }
}
