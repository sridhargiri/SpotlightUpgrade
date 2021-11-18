using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class PatronTripSummaryUpdate
    {
        public long RecId { get; set; }
        public decimal? TheoWin4Days { get; set; }
        public short? DaysCount4Days { get; set; }
        public decimal? Average4Days { get; set; }
        public decimal? TheoWin3Days { get; set; }
        public short? DaysCount3Days { get; set; }
        public decimal? Average3Days { get; set; }
        public decimal? TheoWin5Days { get; set; }
        public int? DaysCount5Days { get; set; }
        public decimal? Average5Days { get; set; }
    }
}
