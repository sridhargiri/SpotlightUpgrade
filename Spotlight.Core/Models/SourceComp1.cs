using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceComp1
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public int RedemptionId { get; set; }
        public DateTime? Timestamp { get; set; }
        public int CasinoId { get; set; }
        public string PlayerBk { get; set; }
        public DateTime? IssueDateTime { get; set; }
        public DateTime? IssueGamingDate { get; set; }
        public int? IssueUserId { get; set; }
        public DateTime? SettleDateTime { get; set; }
        public DateTime? SettleGamingDate { get; set; }
        public int? SettleUserId { get; set; }
        public DateTime? VoidDateTime { get; set; }
        public DateTime? VoidGamingDate { get; set; }
        public int? VoidUserId { get; set; }
        public int? VoidSupervisorId { get; set; }
        public int? PrizeId { get; set; }
        public int? Quantity { get; set; }
        public string CompDescription { get; set; }
        public string CompDescription2 { get; set; }
        public decimal? OriginalComp { get; set; }
        public decimal? Comp { get; set; }
        public decimal? RedeemingOriginalComp { get; set; }
        public long? Crc { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? ExpiryGamingDate { get; set; }

        public virtual SourceEmployee1 SourceEmployee1 { get; set; }
    }
}
