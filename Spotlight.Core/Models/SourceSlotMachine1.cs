using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceSlotMachine1
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string SlotMachineId { get; set; }
        public string SlotNumber { get; set; }
        public string SlotMachineName { get; set; }
        public string SlotRevision { get; set; }
        public string VendorName { get; set; }
        public string Game { get; set; }
        public decimal? Denomination { get; set; }
        public string BankId { get; set; }
        public string SlotFloor { get; set; }
        public string SlotArea { get; set; }
        public string SlotSection { get; set; }
        public long? Crc { get; set; }
    }
}
