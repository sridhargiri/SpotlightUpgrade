using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ReportParameter
    {
        public long ReportParameterId { get; set; }
        public long ReportMasterId { get; set; }
        public string ParameterDescription { get; set; }
        public string ParameterSp { get; set; }
        public int? ParameterOrder { get; set; }
        public string ParameterTextValue { get; set; }
        public int? ParameterIntValue { get; set; }
        public double? ParameterFloatValue { get; set; }
    }
}
