using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class Post
    {
        [Key]
        public int PostId { get; set; }

        public DateTime CreatedAt { get; set; }

        public byte[] Image { get; set; }

        public string  Title {get;set;}

        public string Body { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsApproved { get; set; }

        public double Votes { get; set; }

        public bool IsFlagged { get; set; }
    }
}
