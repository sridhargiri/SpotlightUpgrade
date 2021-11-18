using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigPeriod
    {
        public int PeriodId { get; set; }
        public string PeriodDesc { get; set; }
        public int? PeriodNumber { get; set; }
        public string PeriodType { get; set; }
    }
}
