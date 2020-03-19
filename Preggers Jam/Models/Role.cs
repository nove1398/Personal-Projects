using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Preggers_Jam.Models
{
    class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string Name { get; set; }

        public string description { get; set; }


    }
}
