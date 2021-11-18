using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportAudit
    {
        public long ReportAuditId { get; set; }
        public long ReportMasterId { get; set; }
        public long ReportUserId { get; set; }
        public string Ipaddress { get; set; }
        public string Action { get; set; }
        public DateTime ActionTimestamp { get; set; }
        public string ActionSp { get; set; }
    }
}
