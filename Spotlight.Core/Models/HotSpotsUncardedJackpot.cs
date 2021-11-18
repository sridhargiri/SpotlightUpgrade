using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HotSpotsUncardedJackpot
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string BufferBk { get; set; }
        public string SlotMastBk { get; set; }
        public string RevisionBk { get; set; }
        public string SlotNumber { get; set; }
        public string Location { get; set; }
        public double? Denomination { get; set; }
        public double? JackpotAmount { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
        public DateTime? AlertSentDateTime { get; set; }
        public bool? AlertSent { get; set; }
    }
}
