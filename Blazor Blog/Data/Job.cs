using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Blog.Data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        [Required]
        public int Salary { get; set; }

        public decimal GetSalary()
        {
            return (Salary / 100);
        }
    }
}
