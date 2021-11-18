using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceCompAdjustment
    {
        public int PropertyId { get; set; }
        public int RedemptionId { get; set; }
        public DateTime Timestamp { get; set; }
        public int CasinoId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime? IssueDateTime { get; set; }
        public DateTime? IssueGamingDate { get; set; }
        public int? IssueUserId { get; set; }
        public DateTime? SettleDateTime { get; set; }
        public DateTime? SettleGamingDate { get; set; }
        public DateTime? VoidDateTime { get; set; }
        public int? PrizeId { get; set; }
        public int? Quantity { get; set; }
        public string CompDescription { get; set; }
        public string CompDescription2 { get; set; }
        public decimal? OriginalComp { get; set; }
        public decimal? Comp { get; set; }
        public decimal? RedeemingOriginalComp { get; set; }
        public long? Crc { get; set; }
    }
}
