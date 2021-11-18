using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostTaskPatron
    {
        public HostTaskPatron()
        {
            HostTaskHosts = new HashSet<HostTaskHost>();
        }

        public long HostTaskPatronKey { get; set; }
        public long HostTaskKey { get; set; }
        public bool HostTaskCompleted { get; set; }
        public int PropertyId { get; set; }
        public string HostTaskPatronId { get; set; }
        public int HostTaskCompletedBy { get; set; }
        public DateTime HostTaskCompletedDateTime { get; set; }
        public string Notes { get; set; }

        public virtual HostTaskManager HostTaskKeyNavigation { get; set; }
        public virtual SourcePatron1 SourcePatron1 { get; set; }
        public virtual ICollection<HostTaskHost> HostTaskHosts { get; set; }
    }
}
