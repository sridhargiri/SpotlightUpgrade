using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewWhosHereLastPosition
    {
        public int? PropertyId { get; set; }
        public string PlayerId { get; set; }
        public string Activity { get; set; }
        public string Location { get; set; }
        public string Asset { get; set; }
        public DateTime? ActivityDateTime { get; set; }
        public long? RecId { get; set; }
    }
}
