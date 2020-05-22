using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp.Client.Shared.Models
{
    public class AppGroups
    {
        [Key]
        public int AppGroupId { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Max 500 characters")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
