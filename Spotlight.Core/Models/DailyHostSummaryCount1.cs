using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class DailyHostSummaryCount1
    {
        public long DailyCountsId { get; set; }
        public int PropertyId { get; set; }
        public DateTime? GamingDate { get; set; }
        public int? Patrons { get; set; }
        public int? Contacts { get; set; }
        public int? AlertsSent { get; set; }
        public int? AlertsContacted { get; set; }
    }
}
