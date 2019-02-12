using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.EntityModels
{
    public class User
    {
        public int UserId { get; set; }
        public UserUserType UserUserType { get; set; }
        public int UserUserTypeId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
