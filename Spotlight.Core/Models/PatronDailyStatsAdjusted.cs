using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronDailyStatsAdjusted
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime GamingDate { get; set; }
        public decimal? PointsAdjusted { get; set; }
        public decimal? DollarsAdjusted { get; set; }
        public decimal? CompsAdjusted { get; set; }
        public long? Crcadjustments { get; set; }
    }
}
