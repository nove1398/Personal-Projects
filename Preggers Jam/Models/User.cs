﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class User
    {
        [Key]   
        public int UserId { get; set; }

        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public DateTime? LastOnline { get; set; }

        public bool IsActive { get; set; }

    }
}
