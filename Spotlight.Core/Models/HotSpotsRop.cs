using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HotSpotsRop
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string PlayerType { get; set; }
        public string PlayerName { get; set; }
        public string SlotMastBk { get; set; }
        public string RevisionBk { get; set; }
        public string SlotNumber { get; set; }
        public string Location { get; set; }
        public double? Denomination { get; set; }
        public int? BillsIn { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? TransTimeSeconds { get; set; }
        public int? TransCount { get; set; }
        public double? TransSeconds { get; set; }
        public double? AverageValue { get; set; }
        public double? TransPerMinute { get; set; }
        public double? Rop { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
        public DateTime? AlertSentDateTime { get; set; }
        public bool? AlertSent { get; set; }
    }
}
