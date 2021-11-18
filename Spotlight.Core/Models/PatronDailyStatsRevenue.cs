using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronDailyStatsRevenue
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime GamingDate { get; set; }
        public byte? Trips { get; set; }
        public byte? GamingVisit { get; set; }
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
        public DateTime? MinRatingDateTime { get; set; }
        public DateTime? MaxRatingDateTime { get; set; }
        public decimal AverageBet { get; set; }
        public decimal? FreePlayTheo { get; set; }
        public long? Crc { get; set; }
    }
}
