using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Host
    {
        public long HostsId { get; set; }
        public int? PropertyId { get; set; }
        public int HostUserId { get; set; }
        public string HostUserName { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public long Crc { get; set; }
    }
}
