using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostDeviceSession
    {
        public int PropertyId { get; set; }
        public int HostId { get; set; }
        public int HostUserId { get; set; }
        public Guid DeviceId { get; set; }
        public DateTime IssuedTime { get; set; }
        public DateTime ExpiredTime { get; set; }
        public DateTime LastSignInTime { get; set; }
        public DateTime? LastSignOutTime { get; set; }
        public bool Active { get; set; }
        public string Ipaddress { get; set; }
    }
}
