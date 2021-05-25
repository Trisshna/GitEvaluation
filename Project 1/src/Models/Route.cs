using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementApplication.Models
{
    public class Route
    {

        [Key]
        public int RootNumber { get; set; }
        public int VehicleId { get; set; }
        public int Stop1 { get; set; }
        public int Stop2 { get; set; }
        public int Stop3 { get; set; }
    }
}
