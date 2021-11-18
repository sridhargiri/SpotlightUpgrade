using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewAllComp
    {
        public DateTime? IssuedDate { get; set; }
        public TimeSpan? IssuedTime { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? SettledDate { get; set; }
        public TimeSpan? SettledTime { get; set; }
        public string SettledBy { get; set; }
        public DateTime? VoidDate { get; set; }
        public TimeSpan? VoidTime { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public TimeSpan? ExpiryTime { get; set; }
        public string Description { get; set; }
        public decimal? CompAmount { get; set; }
        public string Status { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
    }
}
