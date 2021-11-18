using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceSlotMachineRevision1
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string SlotMachineId { get; set; }
        public string SlotNumber { get; set; }
        public string SlotRevision { get; set; }
        public string Active { get; set; }
        public DateTime? RevisionStartDate { get; set; }
        public DateTime? RevisionEndDate { get; set; }
        public string CasinoCode { get; set; }
        public string Area { get; set; }
        public string Section { get; set; }
        public string Location { get; set; }
        public string LocationString { get; set; }
        public decimal? Denomination { get; set; }
        public double? Par { get; set; }
        public long? Crc { get; set; }
    }
}
