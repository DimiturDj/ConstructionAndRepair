
﻿using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;


namespace RepairAndConstruction.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "Password cannot be longer than 100 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Role { get; set; } // Added Role field to the model
    }
}
