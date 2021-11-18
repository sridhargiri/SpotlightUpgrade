using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ParamDate
    {
        public DateTime Days { get; set; }
        public int PropertyId { get; set; }
        public DateTime? StartGamingDate { get; set; }
        public DateTime? EndGamingDate { get; set; }
    }
}
