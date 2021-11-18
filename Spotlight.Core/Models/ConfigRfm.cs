using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigRfm
    {
        public long Rfmid { get; set; }
        public long RfmpropertyId { get; set; }
        public DateTime RfmgamingDate { get; set; }
        public short Rfmscore { get; set; }
        public short? RfmpercentFrom { get; set; }
        public short? RfmpercentTo { get; set; }
        public short? RfmperiodDays { get; set; }
        public DateTime? RfmrecencyFrom { get; set; }
        public DateTime? RfmrecencyTo { get; set; }
        public short? RfmfrequencyFrom { get; set; }
        public short? RfmfrequencyTo { get; set; }
        public decimal? RfmmonetaryFrom { get; set; }
        public decimal? RfmmonetaryTo { get; set; }
    }
}
