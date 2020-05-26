using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut_10.Models;

namespace tut_10.Services
{
    public class SqlServerDoctorDbService : IDoctorDbService
    {

        private readonly DoctorDbContext _context;
        public SqlServerDoctorDbService(DoctorDbContext context)
        {
            _context = context;
        }

        public string addDoctor(Doctor doctor)
        {
            var res = _context.Doctor.Any(e => e.IdDoctor == doctor.IdDoctor);
            if (res == true)
            {
                // return BadRequest("There is a doctor with this id!");
                throw new Exception("There is a doctor with this id!");

            }
            else
            {

                _context.Doctor.Add(doctor);
                _context.SaveChanges();
                //return Ok("Succesfully added!");
                return "Succesfully added!";
            }
        }

        public string deleteDoctor(int id)
        {
            var res = _context.Doctor.Any(e => e.IdDoctor == id);
            if (res == true)
            {
                var res2 = _context.Doctor.Find(id);
                _context.Doctor.Remove(res2);
                _context.SaveChanges();
                //return Ok("Succesfully deleted!");
                return "Succesfully deleted!";
            }
            else
            {
                //return NotFound("There is no  such record!");
                throw new Exception ("There is no  such record!");
            }
        }

        public IQueryable getDoctor(int id)
        {
            var res = _context.Doctor.Any(e => e.IdDoctor == id);

            if (res == true)
            {
                var res2 = _context.Doctor.Include(e => e.Prescriptions)
                                                       .Where(e => e.IdDoctor == id)
                                                       .Select(e => new {
                                                           e.IdDoctor,
                                                           e.FirstName,
                                                           e.LastName,
                                                           e.Email,
                                                           PrescriptionList = e.Prescriptions
                                                           .Select(e => e.IdPrescription)
                                                           .ToList()});

                //return Ok(res2);
                return res2;
            }
            else
            {

                //return NotFound("There is no  such record!");
                throw new Exception("There is no  such record!");
            }
        }

        public IQueryable getDoctors()
        {
            var res =_context.Doctor.Include(e => e.Prescriptions)
                                                        .Select(e => new {
                                                            e.IdDoctor,
                                                            e.FirstName,
                                                            e.LastName,
                                                            e.Email,
                                                            PrescriptionList = e.Prescriptions
                                                                                        .Select(e => e.IdPrescription)
                                                                                        .ToList()});

            //return Ok(res);
            return res;
        }

        public string modifyDoctor(Doctor doctor)
        {
            var res = _context.Doctor.Any(e => e.IdDoctor == doctor.IdDoctor);

            if (res == true)
            {
                var res2 = _context.Doctor.Find(doctor.IdDoctor);
                res2.FirstName = doctor.FirstName;
                res2.LastName = doctor.LastName;
                res2.Email = doctor.Email;
                _context.SaveChanges();
                //return Ok("Succesfully updated!");
                return "Succesfully updated!";

            }
            else
            {
                //return NotFound("There is no such doctor!");
                throw new Exception ("There is no such doctor!");
            }
        }
    }
}
