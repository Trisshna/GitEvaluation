using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagementApplication.Models
{
    public class Login
    {
        [Key]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
