using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourceAccountStatus1
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public string StatusBk { get; set; }
        public string StatusName { get; set; }
        public long? Crc { get; set; }
    }
}
