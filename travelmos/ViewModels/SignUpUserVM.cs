using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.ViewModels
{
    public class SignUpUserVM
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Guide")]
        public bool IsGuide { get; set; }
        [DisplayName("Tourist")]
        public bool IsTourist { get; set; }

        [DisplayName("Primary language")]
        public int PrimaryLanguageId { get; set; }
        public List<SelectListItem> Languages { get; set; }
    }
}
