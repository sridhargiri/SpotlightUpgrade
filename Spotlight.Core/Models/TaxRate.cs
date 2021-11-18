using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class TaxRate
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string StatType { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double TaxRate1 { get; set; }
    }
}
