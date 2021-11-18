using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewSourceCompsComp
    {
        public int PropertyId { get; set; }
        public int? UserId { get; set; }
        public int? SettleUserId { get; set; }
        public DateTime? GamingDate { get; set; }
        public DateTime? IssueDateTime { get; set; }
        public DateTime? SettleDateTime { get; set; }
        public string PlayerBk { get; set; }
        public int? Quantity { get; set; }
        public decimal? CompAmount { get; set; }
        public string CompDescription { get; set; }
        public string RecType { get; set; }
    }
}
