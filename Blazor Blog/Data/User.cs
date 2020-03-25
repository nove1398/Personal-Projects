using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Blog.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(5,ErrorMessage = "Username cannot be blank")]
        public string Username { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Invalid first name entered")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Invalid last name entered")]
        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }

       public bool Active { get; set; }
       
    }
}
