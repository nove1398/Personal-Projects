using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp.Shared.Models
{
    public class RegisterRequest
    {

        [Required]
        [EmailAddress]
        [MaxLength(200,ErrorMessage = "Too long")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Too long")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Too long")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Too long")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
