using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class EducationHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationHistoryId { get; set; }
        public string FieldOfStudy { get; set; }

        public string EducationLevel { get; set; }

        public int PersonId { get; set; }
        //public Person Person { get; set; }
    }
}
