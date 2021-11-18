using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigDate
    {
        public long DateKey { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? ActualYear { get; set; }
        public int? ActualQuarter { get; set; }
        public int? ActualMonth { get; set; }
        public int? ActualDayOfYear { get; set; }
        public int? ActualDay { get; set; }
        public int? ActualWeek { get; set; }
        public int? ActualWeekDay { get; set; }
        public int? Isoweek { get; set; }
    }
}
