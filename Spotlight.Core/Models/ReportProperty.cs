using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportProperty
    {
        public long ReportPropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyDomain { get; set; }
    }
}
