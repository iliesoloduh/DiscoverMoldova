using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiscoverMoldova.Core.Dtos
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "Firstname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Firstname must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lastname must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be between 8 and 50 characters")]
        public string Password { get; set; }
    }
}
