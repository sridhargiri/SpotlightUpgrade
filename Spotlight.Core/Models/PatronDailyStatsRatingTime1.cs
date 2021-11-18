using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronDailyStatsRatingTime1
    {
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime GamingDate { get; set; }
        public string StatType { get; set; }
        public DateTime? MinDateTime { get; set; }
        public DateTime? MaxDateTime { get; set; }
    }
}
