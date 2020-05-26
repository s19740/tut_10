using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tut_10.Models;
using tut_10.Services;

namespace tut_10.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        // private readonly DoctorDbContext _context;
        IDoctorDbService _service;
        public DoctorController(IDoctorDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult getDoctors()
        {
            var res = _service.getDoctors();
            return Ok(res);
        }
        
        [HttpGet("{id}")]
        public IActionResult getDoctor(int id)
        {
            var res = _service.getDoctor(id);

            return Ok(res);
        }
        [HttpPost]
        public IActionResult addDoctor(Doctor doctor)
        {
            var res = _service.addDoctor(doctor);
            return Ok(res);

        }
        [HttpPut]
        public IActionResult modifyDoctor(Doctor doctor)
        {
            var res = _service.modifyDoctor(doctor);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteDoctor(int id)
        {
            var res = _service.deleteDoctor(id);
            return Ok(res);
        }
    }
}