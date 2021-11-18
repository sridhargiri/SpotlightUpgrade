using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Csr
    {
        public int? PropertyId { get; set; }
        public string Property { get; set; }
        public string UserAd { get; set; }
        public int? HostUserId { get; set; }
        public string HostUserName { get; set; }
    }
}
