using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewLastContactDateTimeView
    {
        public int PropertyId { get; set; }
        public string PatronId { get; set; }
        public DateTime? LastContactDateTime { get; set; }
        public int? DaysSinceLastContact { get; set; }
        public int SortOrder { get; set; }
        public string Color { get; set; }
    }
}
