using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewWhosHereTableMostRecent
    {
        public int PropertyId { get; set; }
        public string PlayerId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Pit { get; set; }
        public string TableId { get; set; }
        public string TablePosition { get; set; }
    }
}
