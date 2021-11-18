using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewHostedReferredPatron
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string HomePhone { get; set; }
        public string Frequency { get; set; }
        public string FrequencyColor { get; set; }
        public string CardLevel { get; set; }
        public int? HostUserId { get; set; }
        public int? ReferralHostUserId { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public int? HostKey { get; set; }
    }
}
