using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronMerge
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string FromPlayerBk { get; set; }
        public string ToPlayerBk { get; set; }
        public DateTime? MergeDateTime { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
    }
}
