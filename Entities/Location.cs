using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; }
        [Required, Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }
        [Required, Column(TypeName = "nchar(2)")]
        public string Province { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Contact { get; set; }
        [Required, Column(TypeName = "char(12)")]
        public string Phone { get; set; }
        [Required]
        public bool Active { get; set; }

        public ICollection<PlacementContract> PlacementContracts { get; set; }
    }
}
