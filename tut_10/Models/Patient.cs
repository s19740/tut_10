using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tut_10.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
