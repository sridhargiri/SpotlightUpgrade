using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportMaster
    {
        public long ReportMasterId { get; set; }
        public long ReportPropertyId { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string ReportVersion { get; set; }
        public bool? ReportActive { get; set; }
        public long? ReportProductId { get; set; }
        public string ReportLocation { get; set; }
        public DateTime? ReportCreated { get; set; }
        public bool? ReportToPdf { get; set; }
        public bool? ReportToExcel { get; set; }
        public bool? ReportToWord { get; set; }
        public string ReportType { get; set; }
    }
}
