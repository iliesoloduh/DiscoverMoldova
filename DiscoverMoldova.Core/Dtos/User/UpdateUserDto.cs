using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiscoverMoldova.Core.Dtos
{
    public class UpdateUserDto
    {
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Firstname must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lastname must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string UserName { get; set; }

        [MinLength(8, ErrorMessage = "Password must be between 8 and 50 characters")]
        public string Password { get; set; }
    }
}
