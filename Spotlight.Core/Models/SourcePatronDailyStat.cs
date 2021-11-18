using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronDailyStat
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string StatType { get; set; }
        public DateTime GamingDate { get; set; }
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
        public DateTime? DateTimeAdded { get; set; }
        public decimal? PointsAdjusted { get; set; }
        public decimal? DollarsAdjusted { get; set; }
        public decimal? CompsAdjusted { get; set; }
        public long? Crcadjustments { get; set; }
        public byte? RedemptionVisit { get; set; }
        public decimal? PointsRedeemed { get; set; }
        public decimal? DollarsRedeemed { get; set; }
        public decimal? CompsRedeemed { get; set; }
        public long? Crcredemptions { get; set; }
        public byte? GamingVisit { get; set; }
        public long? Crc { get; set; }
        public DateTime? MinRatingDateTime { get; set; }
        public DateTime? MaxRatingDateTime { get; set; }
        public decimal AverageBet { get; set; }
        public decimal FreePlayTheo { get; set; }
        public decimal Adt { get; set; }
        public decimal Ada { get; set; }
    }
}
