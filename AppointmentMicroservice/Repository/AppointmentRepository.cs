using AppointmentMicroservice.Data;
using AppointmentMicroservice.Model;
using AppointmentMicroservice.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentMicroservice.Repository
{
    public class AppointmentRepository:IAppointmentRepository
    {
        private readonly ApplicationDbContext _db;

        public AppointmentRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public bool CreateAppointment(Appointment appointment)
        {
            _db.Appointments.Add(appointment);
            return Save();
        }

        public bool DeleteAppointment(Appointment appointment)
        {
            _db.Appointments.Remove(appointment);
            return Save();
        }

        public ICollection<Appointment> GetAppointments()
        {
            return _db.Appointments.OrderBy(a => a.Id).ToList();
        }

        public bool AppointmentExists(int id)
        {
            return _db.Appointments.Any(a => a.Id == id);

        }

        public Appointment GetAppointment(int id)
        {
            return _db.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateAppointment(Appointment appointment)
        {
            _db.Appointments.Update(appointment);
            return Save();
        }
    }
}
