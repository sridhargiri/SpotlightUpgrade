using System;
using System.Collections.Generic;

#nullable disable

namespace Spotlight.Core.Models
{
    public partial class ConfigRfmdate
    {
        public long RecId { get; set; }
        public long PropertyId { get; set; }
        public DateTime RfmgamingDate { get; set; }
    }
}
