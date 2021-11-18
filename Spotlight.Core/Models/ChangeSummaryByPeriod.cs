using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ChangeSummaryByPeriod
    {
        public long RecId { get; set; }
        public int? Trips { get; set; }
        public long Crc { get; set; }
    }
}
