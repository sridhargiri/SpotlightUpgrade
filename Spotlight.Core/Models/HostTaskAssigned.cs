using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostTaskAssigned
    {
        public long HostTaskKey { get; set; }
        public int HostUserId { get; set; }

        public virtual HostTaskManager HostTaskKeyNavigation { get; set; }
        public virtual Host1 HostUser { get; set; }
    }
}
