using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigDatum
    {
        public int ConfigDataId { get; set; }
        public int Property { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public short DurationFrom { get; set; }
        public int DurationTo { get; set; }
        public string DurationType { get; set; }
    }
}
