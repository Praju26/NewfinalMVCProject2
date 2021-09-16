using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewfinalMVCProject2.Data.Model
{
    public class MedicalEnterpriser
    {
          [Key]
        public int  ID { get; set; }
        public String MedName { get; set; }
        public String MedDescription { get; set; }
        public String MedAddress { get; set; }
        public String Time_at { get; set; }
    }
}
