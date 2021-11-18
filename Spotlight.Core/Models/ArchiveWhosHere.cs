using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ArchiveWhosHere
    {
        public int ArchiveAlertId { get; set; }
        public int? PropertyId { get; set; }
        public string RecipientEmailAddress { get; set; }
        public string PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public string Asset { get; set; }
        public int? HostUserId { get; set; }
        public double? Adt { get; set; }
        public DateTime? ActivityDateTime { get; set; }
        public DateTime? AlertSentTimestamp { get; set; }
    }
}
