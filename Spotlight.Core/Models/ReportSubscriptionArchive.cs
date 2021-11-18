using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportSubscriptionArchive
    {
        public long ReportSubscriptionArchiveId { get; set; }
        public long ReportSubscriptionId { get; set; }
        public long ReportUserId { get; set; }
        public long ReportMasterId { get; set; }
        public DateTime DateTimeSent { get; set; }
        public string EmailAddress { get; set; }
        public string EmailMessage { get; set; }
    }
}
