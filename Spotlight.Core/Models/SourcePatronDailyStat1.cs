using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronDailyStat1
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public string StatType { get; set; }
        public DateTime GamingDate { get; set; }
        public decimal? FreePlayTheo { get; set; }
    }
}
