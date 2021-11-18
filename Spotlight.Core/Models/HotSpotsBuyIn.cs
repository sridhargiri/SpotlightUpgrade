using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HotSpotsBuyIn
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public long BuyInId { get; set; }
        public long RatingId { get; set; }
        public DateTime? StatDateTime { get; set; }
        public string PitName { get; set; }
        public string GameName { get; set; }
        public string LocationName { get; set; }
        public int? Seat { get; set; }
        public double? BuyInAmount { get; set; }
        public string Description { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
        public DateTime? AlertSentDateTime { get; set; }
        public bool? AlertSent { get; set; }
    }
}
