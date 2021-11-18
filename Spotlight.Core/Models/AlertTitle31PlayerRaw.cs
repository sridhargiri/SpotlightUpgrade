using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class AlertTitle31PlayerRaw
    {
        public int AlertId { get; set; }
        public int? PropertyId { get; set; }
        public string PlayerId { get; set; }
        public decimal? TotalBuyIn { get; set; }
        public DateTime? GamingDate { get; set; }
    }
}
