using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronHostReferral1
    {
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string HostUserId { get; set; }
        public DateTime? HostUserIdTimestamp { get; set; }
        public string ReferralUserId { get; set; }
        public DateTime? ReferrralUserIdTimestamp { get; set; }
    }
}
