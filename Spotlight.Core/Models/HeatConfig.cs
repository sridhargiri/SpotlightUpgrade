using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class HeatConfig
    {
        public int Property { get; set; }
        public int? ConfigDataId { get; set; }
        public string Descr { get; set; }
        public string Color { get; set; }
        public int? BeginPt { get; set; }
        public int? EndPt { get; set; }
    }
}
