using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class Message
    {
        [Key]
        public int MessageId { get; set; }

        public DateTime? SentAt { get; set; }

        public DateTime? ReadAt { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }

        public int FromId { get; set; }
        public User UserFrom { get; set; }

        public int ToId { get; set; }
        public User UserTo { get; set; }

        public bool IsUrgent { get; set; }


    }
}
