using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronDailyStatsRedemption
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime GamingDate { get; set; }
        public byte? Trips { get; set; }
        public byte? RedemptionVisit { get; set; }
        public decimal? PointsRedeemed { get; set; }
        public decimal? DollarsRedeemed { get; set; }
        public decimal? CompsRedeemed { get; set; }
        public long? Crcredemptions { get; set; }
    }
}
