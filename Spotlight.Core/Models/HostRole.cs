using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostRole
    {
        public int RoleId { get; set; }
        public int HostHostsId { get; set; }

        public virtual Host1 HostHosts { get; set; }
        public virtual SecurityRole Role { get; set; }
    }
}
