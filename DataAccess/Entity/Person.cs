using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
   public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddeleName { get; set; }
        public string LastName { get; set; }
        public string mobile { get; set; }

        //[Column(TypeName = "nvarchar(10)")]
        public int Gender { get; set; }
        public string JobTitle { get; set; }
        public virtual List<EducationHistory> EducationHistory { get; set; }
    }
}
