using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronReinvestment
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public decimal? ActualWin { get; set; }
        public decimal? CompsRedeemed { get; set; }
        public decimal? DollarsRedeemed { get; set; }
        public decimal? FreePlayRedeemed { get; set; }
        public decimal? FreePlayAdjusted { get; set; }
        public decimal? TotalReinvestment { get; set; }
        public decimal? PlayerWorth { get; set; }
        public double? ReinvestmentPercentage { get; set; }
        public long? Crc { get; set; }
    }
}
