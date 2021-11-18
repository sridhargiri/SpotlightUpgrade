using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewConfigAlertCtrthreshold
    {
        public int? PropertyId { get; set; }
        public long AlertTypeId { get; set; }
        public long? AlertSubTypeId { get; set; }
        public string SubTypeName { get; set; }
        public string DayOfWeek { get; set; }
        public long? DaysOfWeekId { get; set; }
        public double? AlertValue { get; set; }
    }
}
