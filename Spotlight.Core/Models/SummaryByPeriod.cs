using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SummaryByPeriod
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public int PeriodId { get; set; }
        public int? Trips { get; set; }
        public long Crc { get; set; }
    }
}
