using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp.Client.Shared.Models
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Salt { get; set; }

        public string Picture { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? LastUpdate { get; set; }

        public bool IsActive { get; set; }

        public string Country { get; set; }

    }
}
