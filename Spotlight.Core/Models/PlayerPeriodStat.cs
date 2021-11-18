using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PlayerPeriodStat
    {
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public int? Trips { get; set; }
        public int? TimePlayed { get; set; }
        public decimal? CashIn { get; set; }
        public decimal? CashOut { get; set; }
        public decimal? Jackpot { get; set; }
        public decimal? TheoWin { get; set; }
        public decimal? ActualWin { get; set; }
        public int? PtsEarned { get; set; }
        public int? PromoPtsEarned { get; set; }
        public decimal? DollarsEarned { get; set; }
        public decimal? PromoDollarsEarned { get; set; }
        public decimal? CompEarned { get; set; }
        public decimal? BonusBucksEarned { get; set; }
        public decimal? FreePlayPlayed { get; set; }
        public decimal? PointsAdjusted { get; set; }
        public decimal? DollarsAdjusted { get; set; }
        public decimal? CompsAdjusted { get; set; }
        public long? Crcadjustments { get; set; }
        public int? RedemptionVisit { get; set; }
        public decimal? PointsRedeemed { get; set; }
        public decimal? DollarsRedeemed { get; set; }
        public decimal? CompsRedeemed { get; set; }
        public long? Crcredemptions { get; set; }
        public int? GamingVisit { get; set; }
        public int? PeriodId { get; set; }
        public string Period { get; set; }
        public decimal? Adt { get; set; }
        public decimal? Ada { get; set; }
    }
}
