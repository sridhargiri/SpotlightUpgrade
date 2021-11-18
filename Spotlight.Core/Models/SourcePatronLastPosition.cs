using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronLastPosition
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public string Asset { get; set; }
        public DateTime? ActivityDateTime { get; set; }
        public long Crc { get; set; }
    }
}
