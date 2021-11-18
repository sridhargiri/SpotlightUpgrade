using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigAlertValue
    {
        public long AlertValueId { get; set; }
        public long AlertTypeId { get; set; }
        public long AlertSubTypeId { get; set; }
        public string DayOfWeek { get; set; }
        public double? AlertValue { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? LastUpdatedUser { get; set; }
    }
}
