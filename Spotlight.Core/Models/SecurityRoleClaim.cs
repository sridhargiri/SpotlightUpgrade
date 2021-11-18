using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SecurityRoleClaim
    {
        public string Resource { get; set; }
        public string Action { get; set; }
        public int RoleId { get; set; }

        public virtual SecurityRole Role { get; set; }
    }
}
