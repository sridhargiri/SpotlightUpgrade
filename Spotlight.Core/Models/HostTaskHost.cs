using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostTaskHost
    {
        public long HostTaskHostId { get; set; }
        public int HostId { get; set; }
        public long HostTaskPatronId { get; set; }
        public long HostTaskKey { get; set; }

        public virtual Host1 Host { get; set; }
        public virtual HostTaskManager HostTaskKeyNavigation { get; set; }
        public virtual HostTaskPatron HostTaskPatron { get; set; }
    }
}
