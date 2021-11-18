using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostSession
    {
        public Guid SessionId { get; set; }
        public int? PropertyId { get; set; }
        public int? HostId { get; set; }
        public int? HostUserId { get; set; }
        public DateTime? IssuedTime { get; set; }
        public DateTime? ExpiredTime { get; set; }
    }
}
