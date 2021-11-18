using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronBalance1
    {
        public int RecId { get; set; }
        public int PropertyId { get; set; }
        public string PlayerBk { get; set; }
        public int? PointsBalance { get; set; }
        public decimal? DollarsBalance { get; set; }
    }
}
