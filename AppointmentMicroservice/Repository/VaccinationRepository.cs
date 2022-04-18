using AppointmentMicroservice.Data;
using AppointmentMicroservice.Model;
using System.Collections.Generic;
using System.Linq;
using VaccinationMicroservice.Repository.IRepository;

namespace VaccinationMicroservice.Repository
{
    public class VaccinationRepository:IVaccinationRepository
    {
        private readonly ApplicationDbContext _db;

        public VaccinationRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public bool CreateVaccination(Vaccination Vaccination)
        {
            _db.Vaccinations.Add(Vaccination);
            return Save();
        }

        public bool DeleteVaccination(Vaccination Vaccination)
        {
            _db.Vaccinations.Remove(Vaccination);
            return Save();
        }

        public ICollection<Vaccination> GetVaccinations()
        {
            return _db.Vaccinations.OrderBy(a => a.Id).ToList();
        }

        public bool VaccinationExists(int id)
        {
            return _db.Vaccinations.Any(a => a.Id == id);

        }

        public Vaccination GetVaccination(int id)
        {
            return _db.Vaccinations.FirstOrDefault(a => a.Id == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateVaccination(Vaccination Vaccination)
        {
            _db.Vaccinations.Update(Vaccination);
            return Save();
        }

    }
}
