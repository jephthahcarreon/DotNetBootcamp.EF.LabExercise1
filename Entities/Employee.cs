using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Required, Column(TypeName = "char(12)")]
        public string HomePhone { get; set; }
        [Required]
        public bool Active { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
