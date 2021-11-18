using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronDailyStatsOver100Adt
    {
        public string PlayerId { get; set; }
        public int PropertyId { get; set; }
        public DateTime GamingDate { get; set; }
        public int? Trips { get; set; }
        public int? TimePlayed { get; set; }
        public decimal? CashIn { get; set; }
        public decimal? CashOut { get; set; }
        public decimal? Jackpot { get; set; }
        public decimal? TheoWin { get; set; }
        public decimal? ActualWin { get; set; }
        public decimal? CompsRedeemed { get; set; }
    }
}
