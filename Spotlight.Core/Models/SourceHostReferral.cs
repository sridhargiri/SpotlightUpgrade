using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceHostReferral
    {
        public int PropertyId { get; set; }
        public int PlayerId { get; set; }
        public int? HostUserId { get; set; }
        public int? ReferralHostUserId { get; set; }
        public string Referral { get; set; }
    }
}
