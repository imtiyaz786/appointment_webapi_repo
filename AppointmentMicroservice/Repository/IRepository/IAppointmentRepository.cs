using AppointmentMicroservice.Model;
using System.Collections.Generic;

namespace AppointmentMicroservice.Repository.IRepository
{
    public interface IAppointmentRepository
    {
        ICollection<Appointment> GetAppointments();
        bool AppointmentExists(int id);
        Appointment GetAppointment(int id);
        bool CreateAppointment(Appointment appointment);
        bool DeleteAppointment(Appointment appointment);
        bool UpdateAppointment(Appointment appointment);
        bool Save();
    }
}
