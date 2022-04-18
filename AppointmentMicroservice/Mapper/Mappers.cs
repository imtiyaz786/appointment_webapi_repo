using AppointmentMicroservice.Model;
using AppointmentMicroservice.Model.Dtos;
using AutoMapper;

namespace AppointmentMicroservice.Mapper
{
    public class Mappers:Profile
    {
        public Mappers()
        {
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<Vaccination, VaccinationDto>().ReverseMap();


        }
    }
}
