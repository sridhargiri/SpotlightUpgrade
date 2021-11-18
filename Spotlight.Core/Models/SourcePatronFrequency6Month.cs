using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronFrequency6Month
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public int? FrequencyValue { get; set; }
        public string Frequency { get; set; }
        public double? NextFrequencyPercent { get; set; }
        public DateTime? DateTimeAdded { get; set; }
        public bool? Current { get; set; }
        public long? Crc { get; set; }
    }
}
