using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class Top20LogPoker1
    {
        public int Top20LogId { get; set; }
        public int? PropertyId { get; set; }
        public string PlayerId { get; set; }
        public DateTime? GamingDate { get; set; }
        public DateTime? EarliestEntry { get; set; }
        public DateTime? LatestEntry { get; set; }
        public int? Entries { get; set; }
    }
}
