using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HostTaskAutoGenerator
    {
        public long HostTaskGeneratorKey { get; set; }
        public long HostTaskManagerId { get; set; }
        public bool CoinIn { get; set; }
        public bool TheoreticalWin { get; set; }
        public bool ActualWin { get; set; }
        public string DurationPeriod { get; set; }
        public int Duration { get; set; }
        public double? PercentageOver { get; set; }
        public double? PercentageUnder { get; set; }
        public bool OnProperty { get; set; }
        public bool AutoHost { get; set; }
        public int EnteredByUser { get; set; }
        public DateTime EnteredDateTime { get; set; }
        public bool Processed { get; set; }
        public DateTime? ProcessedDateTime { get; set; }
        public DateTime? FromGamingDate { get; set; }
        public double? ValueOver { get; set; }
        public double? ValueUnder { get; set; }
        public DateTime? ToGamingDate { get; set; }
        public bool AddCalendar { get; set; }
        public bool VipOnly { get; set; }

        public virtual HostTaskManager HostTaskManager { get; set; }
    }
}
