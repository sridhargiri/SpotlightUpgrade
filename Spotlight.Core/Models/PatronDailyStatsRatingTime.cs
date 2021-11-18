using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronDailyStatsRatingTime
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime GamingDate { get; set; }
        public string StatType { get; set; }
        public DateTime? MinDateTime { get; set; }
        public DateTime? MaxDateTime { get; set; }
    }
}
