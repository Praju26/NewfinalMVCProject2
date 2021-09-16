using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewfinalMVCProject2.Data.Model
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Medicine")]
        [Required]
        public int MedicineId { get; set; }
        //[ForeignKey("Medicine")]
        //public virtual Medicine Medicinest { get; set; }
    }
}
