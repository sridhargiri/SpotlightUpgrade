using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ChangeSummaryByTrip
    {
        public long RecId { get; set; }
        public string PeriodDesc { get; set; }
        public int? Trips { get; set; }
        public decimal? CashIn { get; set; }
        public decimal? TheoWin { get; set; }
        public decimal? PeriodAdt { get; set; }
        public decimal? ActualWin { get; set; }
        public decimal? PeriodAda { get; set; }
        public decimal? FreePlayPlayed { get; set; }
        public decimal? DollarsRedeemed { get; set; }
        public decimal? CompsRedeemed { get; set; }
        public decimal? DollarsAdjusted { get; set; }
        public decimal? CompsAdjusted { get; set; }
        public decimal? Redemptions { get; set; }
        public decimal? TaxAmount { get; set; }
        public long Crc { get; set; }
    }
}
