using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime Day { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal HourlyWage { get; set; }
        [Required]
        public bool OverTime { get; set; }

        public int ShiftID { get; set; }
        public Shift Shifts { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employees { get; set; }
    }
}
