using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceNextCardLevel
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string CardLevelBk { get; set; }
        public string CardLevelName { get; set; }
        public double? CardLevelNextValue { get; set; }
        public string CardLevelStatType { get; set; }
        public DateTime? DurationStartDate { get; set; }
        public DateTime? DurationEndDate { get; set; }
        public int? PointsEarned { get; set; }
        public decimal? TotalIn { get; set; }
        public decimal? TotalOut { get; set; }
        public decimal? TheoreticalWin { get; set; }
        public decimal? CompDollarEarned { get; set; }
        public decimal? ActualWin { get; set; }
        public int? TimePlayed { get; set; }
        public double? NextLevelPercent { get; set; }
    }
}
