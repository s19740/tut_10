using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut_10.Models;

namespace tut_10.Services
{
    public interface IDoctorDbService
    {

        IQueryable getDoctors();
        IQueryable getDoctor(int id);
        string addDoctor(Doctor doctor);
        string modifyDoctor(Doctor doctor);
        string deleteDoctor(int id);



    }
}
