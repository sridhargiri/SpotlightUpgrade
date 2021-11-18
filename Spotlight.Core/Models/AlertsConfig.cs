using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class AlertsConfig
    {
        public long? AlertTypeId { get; set; }
        public int? PropertyId { get; set; }
        public string AlertType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
