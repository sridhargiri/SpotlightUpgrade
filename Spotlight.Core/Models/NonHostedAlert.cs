using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class NonHostedAlert
    {
        public int AlertLogId { get; set; }
        public int? PropertyId { get; set; }
        public string PatronId { get; set; }
        public string PatronName { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public string Asset { get; set; }
        public DateTime? ActivityDateTime { get; set; }
        public decimal? Adt { get; set; }
        public decimal? TheoToday { get; set; }
        public string AlertSent { get; set; }
        public string StatusDescription { get; set; }
        public int AlertType { get; set; }
        public int? HostType { get; set; }
        public short? VisitNumber { get; set; }
    }
}
