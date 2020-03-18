using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
