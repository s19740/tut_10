using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tut_10.Models
{
    public class Medicament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedicament { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        
        [MaxLength(100)]
        //[DefaultValue("None")]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }
        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }
    }
}
