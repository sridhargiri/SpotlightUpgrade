using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostLog
    {
        public int HostLogId { get; set; }
        public int HostsId { get; set; }
        public int HostUserId { get; set; }
        public DateTime? LoginDateTime { get; set; }
    }
}
