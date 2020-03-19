using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Body { get; set; }

        public DateTime CreatedAt { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public double Votes { get; set; }

        public bool IsFlagged { get; set; }
    }
}
