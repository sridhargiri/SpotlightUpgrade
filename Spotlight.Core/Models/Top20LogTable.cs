using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Top20LogTable
    {
        public int Top20LogId { get; set; }
        public DateTime? LatestEntry { get; set; }
        public int? Entries { get; set; }
    }
}
