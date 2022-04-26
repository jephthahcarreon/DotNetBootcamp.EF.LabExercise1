using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class PlacementContract
    {
        [Key]
        public int PlacementContractID { get; set; }
        [Required, Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Required, Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }

        public ICollection<Shift> Shifts { get; set; }

    }
}
