using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceHotelActivity
    {
        public int PropertyId { get; set; }
        public int RecordNum { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Ocr { get; set; }
        public string Message { get; set; }
        public string PlayerId { get; set; }
    }
}
