using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp.Client.Shared.Models
{
    public class AppRoles
    {
        [Key]
        public int AppRolesId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Max 100 characters")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
