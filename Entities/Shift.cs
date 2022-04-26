using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }
        [Required]
        public int DayOfWeek { get; set; }
        [Required, Column(TypeName = "time")]
        public TimeSpan StartTime { get; set; }
        [Required, Column(TypeName = "time")]
        public TimeSpan EndTime { get; set; }
        [Required, Column(TypeName = "tinyint")]
        public byte NumberOfEmployees { get; set; }
        [Required]
        public bool Active { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }

        public int PlacementContractID { get; set; }
        public PlacementContract PlacementContracts { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
