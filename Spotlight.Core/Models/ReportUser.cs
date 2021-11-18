using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportUser
    {
        public long ReportUserId { get; set; }
        public long ReportPropertyId { get; set; }
        public string UserName { get; set; }
        public string NetworkUserName { get; set; }
        public bool? Active { get; set; }
    }
}
