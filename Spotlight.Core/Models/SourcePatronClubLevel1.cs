using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class SourcePatronClubLevel1
    {
        public long RecId { get; set; }
        public int PropertyId { get; set; }
        public int PlayerId { get; set; }
        public string ClubLevel { get; set; }
        public long Crc { get; set; }
    }
}
