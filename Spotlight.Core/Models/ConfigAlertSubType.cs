using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigAlertSubType
    {
        public long AlertSubTypeId { get; set; }
        public long AlertTypeId { get; set; }
        public string SubTypeName { get; set; }
        public string Unit { get; set; }
    }
}
