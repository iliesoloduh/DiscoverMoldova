using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiscoverMoldova.Core.Dtos.Resort
{
    public class CreateResortDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Address must be between 3 and 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression("^[0-9]{3,10}$", ErrorMessage = "Invalid Phone Number")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [RegularExpression("^[1-9][0-9]+$", ErrorMessage = "Please enter a valid price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Capacity is required")]
        [RegularExpression("^[1-9][0-9]+$", ErrorMessage = "Please enter a valid capacity")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required]
        public long UserId { get; set; }

        [Required]
        public long LocationId { get; set; }

        public long[] FacilitiesIds { get; set; }
    }
}
