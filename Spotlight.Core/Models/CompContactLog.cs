using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class CompContactLog
    {
        public int CompContactLogId { get; set; }
        public int? ContactLogId { get; set; }
        public int AdjustmentId { get; set; }
        public int PropertyId { get; set; }
        public string PatronId { get; set; }
        public int? PatronHostId { get; set; }
        public int? ContactHostId { get; set; }
        public int? ContactTypeId { get; set; }
        public string ContactNotes { get; set; }
        public DateTime? ContactDateTime { get; set; }
        public byte UpdateFlag { get; set; }
        public long Crc { get; set; }
    }
}
