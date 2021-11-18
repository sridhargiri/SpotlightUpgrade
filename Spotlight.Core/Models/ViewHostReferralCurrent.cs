using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewHostReferralCurrent
    {
        public long Id { get; set; }
        public int PropertyId { get; set; }
        public int PatronId { get; set; }
        public int HostUserId { get; set; }
        public DateTime? HostChanged { get; set; }
        public int HostReferralId { get; set; }
        public DateTime? ReferralChanged { get; set; }
        public int UserChanged { get; set; }
        public DateTime DateTimeChanged { get; set; }
        public bool CurrentRow { get; set; }
        public string SourceSystem { get; set; }
        public bool Authorized { get; set; }
        public string AuthorizedBy { get; set; }
        public DateTime? AuthorizedDateTime { get; set; }
    }
}
