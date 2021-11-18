using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigHoursOfDay
    {
        public long HoursOfDayId { get; set; }
        public int? HourToPass { get; set; }
        public string HourToDisplay { get; set; }
    }
}
