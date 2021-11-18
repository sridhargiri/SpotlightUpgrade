using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ArchivedAlert1
    {
        public string AlertType { get; set; }
        public long? AlertTypeId { get; set; }
        public int? PropertyId { get; set; }
        public string PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int? HostuserId { get; set; }
        public string HostName { get; set; }
        public string PlayerCardLevel { get; set; }
        public decimal? Adt { get; set; }
        public decimal Ada { get; set; }
        public DateTime? AlertSentDate { get; set; }
        public DateTime? MaxAlertSentTimestamp { get; set; }
        public int? MaxHourOfAlert { get; set; }
        public DateTime? NextContactDate { get; set; }
    }
}
