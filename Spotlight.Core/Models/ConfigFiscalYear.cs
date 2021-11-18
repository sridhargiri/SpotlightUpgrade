using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigFiscalYear
    {
        public long FiscalYearId { get; set; }
        public int? FiscalYear { get; set; }
        public DateTime? StartQ1 { get; set; }
        public DateTime? EndQ1 { get; set; }
        public DateTime? StartQ2 { get; set; }
        public DateTime? EndQ2 { get; set; }
        public DateTime? StartQ3 { get; set; }
        public DateTime? EndQ3 { get; set; }
        public DateTime? StartQ4 { get; set; }
        public DateTime? EndQ4 { get; set; }
    }
}
