using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementApplication.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
    }
}
