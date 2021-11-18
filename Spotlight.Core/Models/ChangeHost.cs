using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ChangeHost
    {
        public long HostsId { get; set; }
        public string HostUserName { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public string ActiveFlag { get; set; }
        public string AllowSelect { get; set; }
        public bool? AllowLogin { get; set; }
        public string LdapuserName { get; set; }
    }
}
