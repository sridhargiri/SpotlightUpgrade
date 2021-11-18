using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Player90DayStat
    {
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public int? Trips { get; set; }
        public decimal? CoinIn { get; set; }
        public decimal? CoinOut { get; set; }
        public decimal? Jackpots { get; set; }
        public decimal? Theo { get; set; }
        public decimal? Win { get; set; }
        public int? PntsErnd { get; set; }
        public int? ProPntsErnd { get; set; }
        public decimal? DollErnd { get; set; }
        public decimal? ProDollErnd { get; set; }
        public decimal? CompErnd { get; set; }
        public decimal? BonBuckErnd { get; set; }
        public decimal? FreePlay { get; set; }
    }
}
