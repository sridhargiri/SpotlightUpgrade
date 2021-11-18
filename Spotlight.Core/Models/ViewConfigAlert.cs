using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewConfigAlert
    {
        public int? PropertyId { get; set; }
        public string AlertName { get; set; }
        public string SubTypeName { get; set; }
        public string Unit { get; set; }
        public double? Sun { get; set; }
        public double? Mon { get; set; }
        public double? Tue { get; set; }
        public double? Wed { get; set; }
        public double? Thu { get; set; }
        public double? Fri { get; set; }
        public double? Sat { get; set; }
    }
}
