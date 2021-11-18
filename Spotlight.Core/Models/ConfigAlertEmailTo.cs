using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigAlertEmailTo
    {
        public long AlertEmailToId { get; set; }
        public long AlertTypeId { get; set; }
        public int HostUserId { get; set; }
    }
}
