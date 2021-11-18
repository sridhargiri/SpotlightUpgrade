using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigRfmpatron
    {
        public long RecId { get; set; }
        public string RecType { get; set; }
        public long PropertyId { get; set; }
        public string PatronId { get; set; }
        public DateTime? Recency { get; set; }
        public int? Frequency { get; set; }
        public decimal? Monetary { get; set; }
    }
}
