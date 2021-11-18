using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ChangeHostsXrefMl
    {
        public int HostsXrefId { get; set; }
        public string HostUserName { get; set; }
        public string HostFirstName { get; set; }
        public string HostLastName { get; set; }
        public string HostStatus { get; set; }
        public string PlayerStatus { get; set; }
        public string XrefHostUserName { get; set; }
        public int XrefHostUserId { get; set; }
        public string XrefHostStatus { get; set; }
        public long? Crc { get; set; }
    }
}
