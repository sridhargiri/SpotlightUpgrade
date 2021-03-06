using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigRfmscore
    {
        public long RecId { get; set; }
        public DateTime? Recency { get; set; }
        public int? Frequency { get; set; }
        public decimal? Monetary { get; set; }
        public short? RecencyScore { get; set; }
        public short? FrequencyScore { get; set; }
        public short? MonetaryScore { get; set; }
        public short? Rfmscore { get; set; }
        public double? Rfmpercent { get; set; }
    }
}
