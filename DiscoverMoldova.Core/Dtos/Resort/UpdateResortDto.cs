using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiscoverMoldova.Core.Dtos.Resort
{
    public class UpdateResortDto
    {
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Address must be between 3 and 100 characters")]
        public string Address { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [RegularExpression("^[0-9]{3,10}$", ErrorMessage = "Invalid Phone Number")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }

        [RegularExpression("^[1-9][0-9]+$", ErrorMessage = "Please enter a valid price")]
        public int? Price { get; set; }

        [RegularExpression("^[1-9][0-9]+$", ErrorMessage = "Please enter a valid capacity")]
        public int? Capacity { get; set; }
        public string Description { get; set; }
        public long? LocationId { get; set; }
    }
}
