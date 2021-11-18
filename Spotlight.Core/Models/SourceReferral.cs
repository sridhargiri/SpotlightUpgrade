using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceReferral
    {
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string ReferralUserId { get; set; }
        public DateTime ReferrralTimestamp { get; set; }
    }
}
