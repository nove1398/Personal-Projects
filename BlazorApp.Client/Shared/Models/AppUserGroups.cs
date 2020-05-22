using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Client.Shared.Models
{
    public class AppUserGroups
    {

        public int AppUserId { get; set; }
        public int AppGroupId { get; set; }

        public DateTime? JoinedOn { get; set; }

        public AppGroups AppGroup { get; set; }
        public AppUser AppUser { get; set; }
    }
}
