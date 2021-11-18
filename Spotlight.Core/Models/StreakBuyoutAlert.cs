using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class StreakBuyoutAlert
    {
        public long RecId { get; set; }
        public string PlayerBk { get; set; }
        public string PlayerName { get; set; }
        public string HostName { get; set; }
        public string CurrentTier { get; set; }
        public string StreakTier { get; set; }
        public decimal StreakAmount { get; set; }
        public DateTime? FirstAlertSent { get; set; }
        public DateTime? LastAlertSent { get; set; }
        public bool? ContactMade { get; set; }
        public bool? Participated { get; set; }
        public DateTime? ParticipatedDateTime { get; set; }
    }
}
