using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewSourceCompsExpired
    {
        public int PropertyId { get; set; }
        public int? UserId { get; set; }
        public DateTime? GamingDate { get; set; }
        public DateTime? IssueDateTime { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public string PlayerBk { get; set; }
        public int? Quantity { get; set; }
        public decimal? CompAmount { get; set; }
        public string CompDescription { get; set; }
        public string RecType { get; set; }
    }
}
