using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SlotMachineUnderSpotlight
    {
        public int SlotMachineId { get; set; }
        public int SlotNumber { get; set; }
        public int Asset { get; set; }
        public string SlotArea { get; set; }
        public string SlotSection { get; set; }
        public string BankId { get; set; }
    }
}
