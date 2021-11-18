using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewReportSecurity
    {
        public long ReportUserSecurityId { get; set; }
        public long ReportMasterId { get; set; }
        public string ReportName { get; set; }
        public long ReportUserId { get; set; }
        public string UserName { get; set; }
        public bool MultiUser { get; set; }
    }
}
