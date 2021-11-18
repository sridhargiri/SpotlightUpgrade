using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewLastContactDateTime
    {
        public int PropertyId { get; set; }
        public string PatronId { get; set; }
        public string Color { get; set; }
        public int? SortOrder { get; set; }
    }
}
