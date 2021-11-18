using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            HostRoles = new HashSet<HostRole>();
            SecurityRoleClaims = new HashSet<SecurityRoleClaim>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCustomizable { get; set; }
        public string ActiveDirectoryGroup { get; set; }
        public int RoleLevel { get; set; }

        public virtual ICollection<HostRole> HostRoles { get; set; }
        public virtual ICollection<SecurityRoleClaim> SecurityRoleClaims { get; set; }
    }
}
