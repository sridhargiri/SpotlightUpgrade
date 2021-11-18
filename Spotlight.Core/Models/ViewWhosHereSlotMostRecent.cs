using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ViewWhosHereSlotMostRecent
    {
        public int? PropertyId { get; set; }
        public string PlayerId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Location { get; set; }
        public string Asset { get; set; }
        public string TransactionDescription { get; set; }
    }
}
