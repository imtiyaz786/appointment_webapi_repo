using AppointmentMicroservice.Model;
using AppointmentMicroservice.Model.Dtos;
using AppointmentMicroservice.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppointmentMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentRepository _npRepo;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentRepository npRepo, IMapper mapper)
        {
            _npRepo = npRepo;
            _mapper = mapper;
        }
        /// <summary>
        /// Get List of Appointments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(400)]
        public IActionResult GetAppointments()
        {
            var objList = _npRepo.GetAppointments();
            var objDto = new List<AppointmentDto>();
            foreach (var item in objList)
            {
                objDto.Add(_mapper.Map<AppointmentDto>(item));
            }
            return Ok(objDto);
        }
        /// <summary>
        /// Get individual Appointment
        /// </summary>
        /// <returns></returns>
        [HttpGet("{appointmentId:int}", Name = "GetAppointment")]

        [ProducesResponseType(200, Type = typeof(AppointmentDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public IActionResult GetAppointment(int appointmentId)
        {
            var obj = _npRepo.GetAppointment(appointmentId);
            if (obj == null)
            {
                return NotFound();
            }

            var ObjDto = _mapper.Map<AppointmentDto>(obj);
            return Ok(ObjDto);
        }

        /// <summary>
        /// Create Appointment
        /// </summary>
        /// <returns></returns>

        [Route("UserAppointments")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(500)]
        public IActionResult CreateAppointment([FromBody] AppointmentDto appointmentDto)
        {
            if (appointmentDto == null)
            {
                return BadRequest(ModelState);
            }


            var appointmentObj = _mapper.Map<Appointment>(appointmentDto);

            if (!_npRepo.CreateAppointment(appointmentObj))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {appointmentObj.Id}");
                return StatusCode(500, ModelState);
            }

            return Ok(appointmentObj);
        }
        /// <summary>
        /// Delete Appointment
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{appointmentId:int}", Name = "DeleteAppointment")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public IActionResult DeleteAppointment(int appointmentId)
        {


            if (!_npRepo.AppointmentExists(appointmentId))
            {
                return NotFound();
            }

            var appointmentObj = _npRepo.GetAppointment(appointmentId);
            if (!_npRepo.DeleteAppointment(appointmentObj))
            {
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
    }
}
