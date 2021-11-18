using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportUserSecurity
    {
        public long ReportUserSecurityId { get; set; }
        public long ReportUserId { get; set; }
        public long ReportMasterId { get; set; }
        public bool MultiProperty { get; set; }
        public bool MultiUser { get; set; }
        public bool? ExportToPdf { get; set; }
        public bool? ExportToExcel { get; set; }
        public bool? ExportToWord { get; set; }
    }
}
