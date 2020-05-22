using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp.Client.Shared.Models
{
    public class AppUserRoles
    {
        [Key]
        public int AppUserRolesId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
