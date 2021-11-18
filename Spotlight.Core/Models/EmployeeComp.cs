using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class EmployeeComp
    {
        public int PropertyId { get; set; }
        public int? HostId { get; set; }
        public string HostName { get; set; }
        public int? PlayerId { get; set; }
        public string PlayerName { get; set; }
        public DateTime? IssueDateTime { get; set; }
        public DateTime? SettleDateTime { get; set; }
        public DateTime? VoidDateTime { get; set; }
        public int? PrizeId { get; set; }
        public string CompDescription { get; set; }
        public int? Quantity { get; set; }
        public decimal? Comp { get; set; }
        public string CompType { get; set; }
    }
}
